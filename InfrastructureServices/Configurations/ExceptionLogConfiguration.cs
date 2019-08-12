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
    public class ExceptionLogConfiguration : IEntityTypeConfiguration<ExceptionLogEntry>
    {
        public void Configure(EntityTypeBuilder<ExceptionLogEntry> builder)
        {
            builder.ToTable("Exceptions");
            builder.HasKey(_=>_.Id);
        }
    }
}
