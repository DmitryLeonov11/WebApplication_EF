using Infrastructure.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfrastructureServices.Configurations
{
    public class AccountsConfiguration : IEntityTypeConfiguration<InfrastructureAccount>
    {
        public void Configure(EntityTypeBuilder<InfrastructureAccount> builder)
        {
            builder.ToTable("Accounts");
            builder.HasKey(_=>_.AccountId);
        }
    }
}
