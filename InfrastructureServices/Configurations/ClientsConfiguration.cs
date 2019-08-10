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
    public class ClientsConfiguration : IEntityTypeConfiguration<InfrastructureClient>
    {
        public void Configure(EntityTypeBuilder<InfrastructureClient> builder)
        {
            builder.ToTable("Clients");

            builder.HasKey(_=>_.ClientId);
        }
    }
}
