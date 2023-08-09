using HR.LeaveManagement.Domain;
using HR.LeaveManagement.Domain.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Persistence.DatabaseContext
{
    public class HrDatabaseContext : DbContext
    {
        public HrDatabaseContext(DbContextOptions<HrDatabaseContext> options) : base(options) 
        {
           
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(HrDatabaseContext).Assembly);

            

            base.OnModelCreating(modelBuilder);
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {

            foreach (var entry in base.ChangeTracker.Entries<BaseEntity>()
                .Where(c => c.State == EntityState.Added || c.State == EntityState.Modified))
            {
                entry.Entity.DateModified = DateTime.UtcNow.AddHours(7);
                
                if(entry.State == EntityState.Added)
                {
                    entry.Entity.DateCreated = DateTime.UtcNow.AddHours(7); 
                }
            }
            return base.SaveChangesAsync(cancellationToken);
        }

        public DbSet<LeaveType> LeaveType { get; set; }
        public DbSet<LeaveAllocation> LeaveAllocation { get; set; }
        public DbSet<LeaveRequest> LeaveRequest { get; set; }
    }
}
