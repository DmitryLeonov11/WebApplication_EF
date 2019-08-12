using Infrastructure.Interfaces;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;
using Infrastructure.Models;

namespace DomainServices.Services
{
    public class ExceptionServices : IExceptionService
    {
        private readonly IExceptionRepository _exceptionRepository;

        public ExceptionServices(IExceptionRepository exceptionRepository)
        {
            _exceptionRepository = exceptionRepository;
        }

        public void ExceptionRequest(ExceptionInfo exceptionInfo)
        {
            _exceptionRepository.Insert(new ExceptionLogEntry()
            {
                Exception = exceptionInfo.Exception
            });
        }
    }
}
