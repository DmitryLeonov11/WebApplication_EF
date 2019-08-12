using Domain.Interfaces;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http.Filters;

namespace WebApplication1.Attributes
{
    public class CustomExceptionFilterAttribute : ExceptionFilterAttribute
    {
        public override void OnException(HttpActionExecutedContext actionExecutedContext)
        {
            var exceptionMessage = string.Empty;
            if(actionExecutedContext.Exception.InnerException == null)
            {
                exceptionMessage = actionExecutedContext.Exception.HResult.ToString();
            }
            else
            {
                exceptionMessage = actionExecutedContext.Exception.InnerException.HResult.ToString();
            }
            var exceptionServices = (IExceptionService)actionExecutedContext.Request.GetDependencyScope().GetService(typeof(IExceptionService));
            exceptionServices.ExceptionRequest(new ExceptionInfo()
            {
                Exception = exceptionMessage
            });
        }
    }
}