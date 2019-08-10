using Domain.Models;
using Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainServices.Mappers
{
    public static class InfrastructureToDomainAccount
    {
        public static DomainAccount AccountToDomain(this InfrastructureAccount @this)
        {
            return new DomainAccount
            {
                AccountId = @this.AccountId,
                Balance = @this.Balance,
                ClientId = @this.ClientId
            };
        }
    }
}
