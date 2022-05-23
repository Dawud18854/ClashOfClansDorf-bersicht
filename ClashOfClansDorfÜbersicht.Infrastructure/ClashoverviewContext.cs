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
            User marko = new User()
            {
                Username = "Marko.I",
                Email = "TestMarko@outlook.com",
                Password = "TestMarko123"
            };

            User dawud = new User()
            {
                Username = "Dawud.H",
                Email = "TestDawud@outlook.com",
                Password = "TestDawud123"
            };

            Users.Add(marko);
            Users.Add(dawud);
            SaveChanges();

            Clan clan = new Clan()
            {
                Description = "IvkoClan",
                Villages = new List<Village>(),
                Member = 1,
                Name = "Warriors"
            };

            Clans.Add(clan);
            SaveChanges();

            Village village = new Village()
            {
                Buildings = new List<Building>(),
                Clan = Clans.Single(c=> c.Name ==clan.Name),
                VillageName = "Dragonrin"
            };

            Villages.Add(village);
            SaveChanges();

            GameAccount dawudGA = new GameAccount()
            {
                CreationDate = DateTime.Now,
                Email = dawud.Email,
                AccountName = "Account1",
                User = Users.Single(u => u.Username == dawud.Username),
                Village = Villages.Single(v => v.VillageName == village.VillageName)
            };

            GameAccounts.Add(dawudGA);
            SaveChanges();

        }
    }
}
