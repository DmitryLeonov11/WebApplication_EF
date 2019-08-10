using Domain.Interfaces;
using Domain.Models;
using DomainServices.Mappers;
using Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainServices.Services
{
    public class AccountServices : IAccountServices
    {
        private readonly IAccountRepository _accountRepository;

        public AccountServices(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        public void AddAccount()
        {
            _accountRepository.AddAccount();
        }

        public DomainAccount GetAccount(int accountId)
        {
            var account = _accountRepository.GetAccount(accountId);
            return account.AccountToDomain();
        }

        public IList<DomainAccount> GetAccounts()
        {
            var accounts = _accountRepository.GetAccounts();
            return accounts.Select(_=>_.AccountToDomain()).ToList();
        }
    }
}
