using Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Interfaces
{
    public interface IAccountRepository
    {
        IList<InfrastructureAccount> GetAccounts();
        InfrastructureAccount GetAccount(int accountId);
        void AddAccount();
    }
}
