using Infrastructure.Models;
using InfrastructureServices.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfrastructureServices.Repositories
{
    public class ClientRepository : DbContext
    {
        private readonly MyContext _context;

        public ClientRepository(MyContext context)
        {
            _context = context;
        }

        public InfrastructureClient GetClient(int clientId)
        {
            return _context.Clients.FirstOrDefault(_=>_.ClientId == clientId);
        }

        public IList<InfrastructureClient> GetClients()
        {
            return _context.Clients.ToList();
        }
    }
}
