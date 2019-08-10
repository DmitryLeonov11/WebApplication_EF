using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.Mappers
{
    public static class DomainToClientModel
    {
        public static ClientModel ClientToModel(this DomainClient @this)
        {
            return new ClientModel
            {
                ClientId = @this.ClientId,
                ClientName = @this.ClientName
            };
        }
    }
}