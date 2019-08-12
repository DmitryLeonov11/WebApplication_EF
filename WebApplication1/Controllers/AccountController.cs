using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.Attributes;
using WebApplication1.Mappers;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [RoutePrefix("accounts")]
    [CustomActionFilter, CustomExceptionFilter]
    public class AccountController : ApiController
    {
        public readonly IAccountServices _accountServices;

        public AccountController(IAccountServices accountServices)
        {
            _accountServices = accountServices;
        }

        [HttpGet, Route("")]
        public List<AccountModel> GetAccounts()
        {
            var accounts = _accountServices.GetAccounts();
            return accounts.Select(_=>_.AccountToModel()).ToList();
        }

        [HttpGet, Route("{accountId:int}")]
        public AccountModel GetAccount(int accountId)
        {
            var account = _accountServices.GetAccount(accountId);
            return account.AccountToModel();
        }

        [HttpPost, Route("add")]
        public void AddAccount()
        {
            _accountServices.AddAccount();
        }

        [HttpPost,Route("post")]
        public void PostAccount([FromBody] AccountModel accountModel)
        {

        }

        [HttpGet, Route("exception")]
        public void Generator()
        {
            throw new ArgumentNullException();
        }
    }
}
