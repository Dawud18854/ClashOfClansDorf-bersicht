using ClashOfClansDorfÜbersicht.Domain.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashOfClansDorfÜbersicht.Infrastructure
{
    public class ClashoverviewContext : DbContext
    {
        public ClashoverviewContext(DbContextOptions options) : base(options)
        { 
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
        }

        public DbSet<User> Users => Set<User>();
        public DbSet<GameAccount> GameAccounts => Set<GameAccount>();
        public DbSet<Village> Villages => Set<Village>();
        public DbSet<Clan> Clans => Set<Clan>();
        public DbSet<Building> Buildings => Set<Building>();


        public void Seed()
        {
            
        }
    }
}
