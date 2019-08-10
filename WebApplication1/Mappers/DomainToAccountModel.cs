using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.Mappers
{
    public static class DomainToAccountModel
    {
        public static AccountModel AccountToModel(this DomainAccount @this)
        {
            return new AccountModel
            {
                AccountID = @this.AccountId,
                Balance = @this.Balance,
                ClientId = @this.ClientId
            };
        }
    }
}