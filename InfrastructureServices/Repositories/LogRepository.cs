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
    public class LogRepository : ILogRepository
    {
        public readonly MyContext _context;

        public LogRepository(MyContext context)
        {
            _context = context;
        }

        public void Insert(RequestLogEntry entry)
        {
            _context.RequestLogEntries.Add(entry);
        }
    }
}
