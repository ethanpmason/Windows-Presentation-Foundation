using CustomerConnectionsApp.EntityFramework.ViewModelServices;
using CustomerConnectionsApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerConnectionsApp.EntityFramework
{
    public class DataContext : DbContext
    {
        DbSet<Customer> Customers { get; set; }
        DbSet<Job> Jobs { get; set; }
        DbSet<Hardware> Hardwares { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //one customer to many jobs relationship
            modelBuilder.Entity<Job>()
                .HasOne<Customer>(c => c.Customer)
                .WithMany(j => j.Jobs)
                .HasForeignKey(s => s.intCustomerId);

            //one job to many hardwares relationship
            modelBuilder.Entity<Hardware>()
                .HasOne<Job>(j => j.Job)
                .WithMany(h => h.Hardwares)
                .HasForeignKey(s => s.intJobId);
        }
        //public DataContext(DbContextOptions<DataContext> options) : base(options)
        //{

        //}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        optionsBuilder.UseSqlServer("Server = (localdb)\\mssqllocaldb; Database = CustomerConnectionsAppDB; Trusted_Connection = True");
        }
    }
}
