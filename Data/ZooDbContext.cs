using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.Models;

namespace Zoo.Data
{
    public class ZooDbContext : DbContext
    {
        public ZooDbContext() : base(Properties.Settings.Default.DbConnect)
        {

        }
        public DbSet<User> User { get; set; }
        public DbSet<Animal> Animal { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Event> Event { get; set; }
        public DbSet<EventsType> EventsType { get; set; }
        public DbSet<TicketsType> TicketsType { get; set; }
        
        public DbSet<UserOrdercs> UserOrdercs { get; set; }
    }
}
