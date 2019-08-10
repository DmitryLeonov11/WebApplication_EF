using Domain.Models;
using Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainServices.Mappers
{
    public static class InfrastructureToDomainClient
    {
        public static DomainClient ClienToDomain(this InfrastructureClient @this)
        {
            return new DomainClient
            {
                ClientId = @this.ClientId,
                ClientName = @this.ClientName
            };
        }
    }
}
