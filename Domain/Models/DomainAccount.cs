using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class DomainAccount
    {
        public int AccountId { get; set; }
        public int Balance { get; set; }
        public int ClientId { get; set; }
    }
}
