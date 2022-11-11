using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;


namespace склад
{
    public class ApplicationContext : DbContext
    {
        public DbSet<sclad> ScladDB { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options)
         : base(options)
        {
            Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<sclad>().HasKey(u => u.Id);
        }
    }
}
