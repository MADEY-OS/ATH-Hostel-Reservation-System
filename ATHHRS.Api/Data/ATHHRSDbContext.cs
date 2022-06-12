using ATHHRS.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace ATHHRS.API.Data
{
    public class ATHHRSDbContext : DbContext
    {
        private string _connectionString =
            @"Server=LAPTOP-SUT4SAOT\SQLEXPRESS; Database = ATHHRSDb; Trusted_Connection=True;";

        public DbSet<Hostel> Hostels { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Rent> Rents { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }

    }
}
