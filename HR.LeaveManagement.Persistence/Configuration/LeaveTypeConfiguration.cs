using HR.LeaveManagement.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Persistence.Configuration
{
    public class LeaveTypeConfiguration : IEntityTypeConfiguration<LeaveType>
    {
        public void Configure(EntityTypeBuilder<LeaveType> builder)
        {   
            builder.HasData(
                    new LeaveType
                    {
                        Id = 1,
                        Name = "Vacation",
                        DateCreated = DateTime.UtcNow.AddHours(7),
                        DateModified = DateTime.UtcNow.AddHours(7),
                    }
                );

            //Configurate Database
            builder.Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(100);
        }
    }
}
