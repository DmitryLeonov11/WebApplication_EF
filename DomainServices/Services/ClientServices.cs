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
    public class ClientServices : IClientsServices
    {
        private readonly IClientRepository _clientRepository;

        public ClientServices(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public DomainClient GetClient(int clientId)
        {
            var client = _clientRepository.GetClient(clientId);
            return client.ClienToDomain();
        }

        public IList<DomainClient> GetClients()
        {
            var clients = _clientRepository.GetClients();
            return clients.Select(_=>_.ClienToDomain()).ToList();
        }
    }
}
