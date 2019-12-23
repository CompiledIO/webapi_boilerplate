using Api.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;
using Api.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Infrastructure.SqlContext
{
    public class SqlDbContext : DbContext
    {
        public SqlDbContext(DbContextOptions<SqlDbContext> options) : base(options) { }

        public DbSet<UserDto> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema(schema: DbGlobals.SchemaName);

            modelBuilder.Entity<UserDto>().HasData(new UserDto
            {
                FirstName = "Administrator",
                LastName = "Developer",
                Email = "test@test.com",
                Password = "password",
                Username = "Admin",
                DateCreated = DateTime.Now,
                DateUpdated = DateTime.Now,
                Id = new Guid("e4b25385-ea86-4d77-acb5-a6b55d097985")
            });;

            base.OnModelCreating(modelBuilder);
        }

        public override int SaveChanges()
        {
            AddAuditInfo();
            return base.SaveChanges();
        }

        public async Task<int> SaveChangesAsync()
        {
            AddAuditInfo();
            return await base.SaveChangesAsync();
        }

        private void AddAuditInfo()
        {
            var entries = ChangeTracker.Entries().Where(x => x.Entity is BaseDto && (x.State == EntityState.Added || x.State == EntityState.Modified));
            foreach (var entry in entries)
            {
                if (entry.State == EntityState.Added)
                {
                    ((BaseDto)entry.Entity).DateCreated = DateTime.UtcNow;
                }
                ((BaseDto)entry.Entity).DateUpdated = DateTime.UtcNow;
            }
        }
    }
}
