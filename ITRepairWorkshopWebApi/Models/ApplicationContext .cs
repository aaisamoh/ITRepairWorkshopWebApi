using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITRepairWorkshopWebApi.Models
{
    public class ApplicationContext:DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Device> Devices { get; set; }
        public DbSet<ImpartPart> ImpartParts { get; set; }
        public DbSet<Part> Parts { get; set; }
        public DbSet<WorkShop> WorkShops { get; set; }
        public DbSet<Expense> Expenses { get; set; }
        public DbSet<Bill> Bills { get; set; }
    
       
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            Database.EnsureCreated();   // create a database on first call
        }
    }
}
