using ServiceStack.FluentValidation.Attributes;
using WebApplication1.Validators;

namespace WebApplication1.Models
{
    [Validator(typeof(AccountModelValidator))]
    public class AccountModel
    {
        public int AccountID { get; set; }
        public int Balance { get; set; }
        public int ClientId { get; set; }
    }
}