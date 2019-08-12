using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Interfaces;
using Infrastructure.Models;
using InfrastructureServices.Contexts;
using InfrastructureServices.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Practices.Unity;

namespace DependencyInjection.Modules
{
    public class InfrastructureModule : IModule
    {
        public void Register(IUnityContainer container)
        {
            var optionsBuilder = new DbContextOptionsBuilder<MyContext>();
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["MyContext"].ConnectionString);

            using (var context = new MyContext(optionsBuilder.Options)) context.Database.EnsureCreated();
            container.RegisterType<MyContext>(new HierarchicalLifetimeManager(), new InjectionConstructor(optionsBuilder.Options));
            
            container.RegisterType<IAccountRepository, AccountRepository>(new ContainerControlledLifetimeManager());
            container.RegisterType<ILogRepository, LogRepository>(new ContainerControlledLifetimeManager());
            container.RegisterType<IClientRepository, ClientRepository>(new ContainerControlledLifetimeManager());
            container.RegisterType<IExceptionRepository, ExceptionRepository>(new ContainerControlledLifetimeManager());
        }
    }
}
