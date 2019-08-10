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
    [RoutePrefix("clients")]
    [CustomActionFilter]
    public class ClientController : ApiController
    {
        public readonly IClientsServices _clientServices;

        public ClientController(IClientsServices clientsServices)
        {
            _clientServices = clientsServices;
        }

        [HttpGet,Route("")]
        public List<ClientModel> Get()
        {
            var clients = _clientServices.GetClients();
            return clients.Select(_=>_.ClientToModel()).ToList();
        }

        [HttpGet,Route("clientId:int")]
        public ClientModel Get(int clientId)
        {
            var client = _clientServices.GetClient(clientId);
            return client.ClientToModel();
        }
    }
}
