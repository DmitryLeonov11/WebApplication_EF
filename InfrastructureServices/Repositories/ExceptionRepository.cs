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
    public class ExceptionRepository : IExceptionRepository
    {
        private readonly MyContext _context;

        public ExceptionRepository(MyContext context)
        {
            _context = context;
        }

        public void Insert(ExceptionLogEntry entry)
        {
            _context.ExceptionLogEntries.Add(entry);
            _context.SaveChanges();
        }
    }
}
