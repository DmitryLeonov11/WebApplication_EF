using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Interfaces;
using DomainServices.Services;
using Microsoft.Practices.Unity;

namespace DependencyInjection.Modules
{
    public class DomainModule : IModule
    {
        public void Register(IUnityContainer container)
        {
            container.RegisterType<IAccountServices, AccountServices>(new HierarchicalLifetimeManager());
            container.RegisterType<IClientsServices, ClientServices>(new HierarchicalLifetimeManager());
        }
    }
}
