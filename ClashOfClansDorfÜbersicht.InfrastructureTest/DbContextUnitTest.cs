using Microsoft.EntityFrameworkCore;
using Xunit;
using ClashOfClansDorfÜbersicht.Infrastructure;

namespace ClashOfClansDorfÜbersicht.InfrastructureTest
{
    [Collection("Sequential")]
    public class DbContextUnitTest
    {
        [Fact]
        public void GenerateDbFromContextTest()
        {
            var options = new DbContextOptionsBuilder()
                .UseSqlite("Data Source=Clash.db")
                .Options;


            using (var db = new ClashoverviewContext(options))
            {
                db.Database.EnsureDeleted();
                db.Database.EnsureCreated();
                db.Seed();
            }
        }
    }
}