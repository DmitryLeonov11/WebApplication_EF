using Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Interfaces
{
    public interface IClientRepository
    {
        IList<InfrastructureClient> GetClients();
        InfrastructureClient GetClient(int clientId);
    }
}
