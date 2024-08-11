using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Lazuli.Api.Data.Mappings;
using Lazuli.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace Lazuli.Api.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public  DbSet<Category> Categories { get; set; } = null!;
        public  DbSet<Transaction> Transactions { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            }
    }
}