using Infrastructure.Models;
using InfrastructureServices.Configurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfrastructureServices.Contexts
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> options) : base(options)
        {
        }

        public virtual DbSet<InfrastructureClient> Clients { get; set; }
        public virtual DbSet<InfrastructureAccount> Accounts { get; set; }
        public virtual DbSet<RequestLogEntry> RequestLogEntries { get; set; }
        public virtual DbSet<ExceptionLogEntry> ExceptionLogEntries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder.
                ApplyConfiguration(new ClientsConfiguration()));
            base.OnModelCreating(modelBuilder.
                ApplyConfiguration(new AccountsConfiguration()));
            base.OnModelCreating(modelBuilder.
                ApplyConfiguration(new RequestLogEntryConfiguration()));
            base.OnModelCreating(modelBuilder.
                ApplyConfiguration(new ExceptionLogConfiguration()));
        }
    }
}
