﻿using Microsoft.EntityFrameworkCore;
using SwiftOrder_Server.Model;

namespace SwiftOrder_Server.Data
{
    public class SwiftOrderDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=SwiftOrderDatabase.sqlite");
        }
        
        public DbSet<Restaurant> Restaurant { get; set; }
        public DbSet<Table> Table { get; set; }
        public DbSet<Menu> Menu { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<Kiosk> Kiosk { get; set; }
        public DbSet<Kiosk> MenuCategory { get; set; }
    }
}
