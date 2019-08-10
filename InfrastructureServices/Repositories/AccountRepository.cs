using Infrastructure.Interfaces;
using Infrastructure.Models;
using InfrastructureServices.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfrastructureServices.Repositories
{
    public class AccountRepository : IAccountRepository
    {
        private readonly MyContext _context;

        public AccountRepository(MyContext context)
        {
            _context = context;
        }

        public void AddAccount()
        {
            InfrastructureAccount account = new InfrastructureAccount()
            {
                Balance = 418,
                ClientId = 7
            };
            _context.Accounts.Add(account);
            _context.SaveChanges();
        }

        public InfrastructureAccount GetAccount(int accountId)
        {
            return _context.Accounts.FirstOrDefault(_=>_.AccountId == accountId);
        }

        public IList<InfrastructureAccount> GetAccounts()
        {
            return _context.Accounts.ToList();
        }
    }
}
