using IUsta.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IUsta.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Master> masters { get; set; }
        public DbSet<Customer> customers { get; set; }
        public DbSet<Category> categories { get; set; }
        public DbSet<Order> orders { get; set; }
        public DataContext() : base("DBconnection") { }
    }
}
