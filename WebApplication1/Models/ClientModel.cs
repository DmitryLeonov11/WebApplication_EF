using ServiceStack.FluentValidation.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Validators;

namespace WebApplication1.Models
{
    [Validator(typeof(ClientModelValidator))]
    public class ClientModel
    {
        public int ClientId { get; set; }
        public string ClientName { get; set; }
    }
}