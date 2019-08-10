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
    public class RequestLogEntryConfiguration : IEntityTypeConfiguration<RequestLogEntry>
    {
        public void Configure(EntityTypeBuilder<RequestLogEntry> builder)
        {
            builder.ToTable("Logs");
            builder.HasKey(_=>_.Id);
        }
    }
}
