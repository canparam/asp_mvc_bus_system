using Bogus;
using BusSystem.Entity;
using BusSystem.Entity.IdentityAccess;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusSystem.Data.Repository
{
    public class BusSystemDbContext : IdentityDbContext<User, Role, string>
    {
        public BusSystemDbContext(DbContextOptions options) : base(options)
        {

        }
        // add table
        public override DbSet<User> Users { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<Wallet> Wallets { get; set; }
        public DbSet<TransactionHis> TransactionHis { get; set; }
        public DbSet<Bus> Bus { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<BusSchedule> BusSchedules { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<OrderDetail> OrderDetail { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            this.SeedWallet(builder);

            this.SeedUsers(builder);

            this.SeedCustomer(builder);

        }
        private void SeedUsers(ModelBuilder builder)
        {
            var password = new PasswordHasher<User>();

            User user = new User()
            {
                Id = "b74ddd14-6340-4840-95c2-db12554843e5",
                UserName = "admin",
                Email = "admin@gmail.com",
                NormalizedUserName = "ADMIN",
                NormalizedEmail = "ADMIN@GMAIL.COM",
                EmailConfirmed = true,
                PasswordHash = password.HashPassword(null, "123123123"),
                Type = 0,
                SecurityStamp = Guid.NewGuid().ToString()
            };

            builder.Entity<User>().HasData(user);

        }
        private void SeedWallet(ModelBuilder builder)
        {
            Wallet wallet = new Wallet()
            {
                Id = 1,
                Amount = 100,
                UserId = "b74ddd14-6340-4840-95c2-db12554843e5",
                CreatedDate = DateTime.Now
            };
            builder.Entity<Wallet>().HasData(wallet);

        }

        private void SeedCustomer(ModelBuilder builder)
        {
            var ids = 1;
            var stock = new Faker<Customer>()
            .RuleFor(m => m.Id, f => ids++)
            .RuleFor(m => m.FullName, f => f.Name.FullName())
            .RuleFor(m => m.Address, f => f.Address.FullAddress())
            .RuleFor(m => m.CreatedDate, DateTime.UtcNow)
            .RuleFor(m => m.Birthday, f => f.Date.PastOffset(60, DateTime.Now.AddYears(-18)).UtcDateTime)
            .RuleFor(m => m.Email, f => f.Internet.Email())
            .RuleFor(m => m.Phone, f => f.Phone.PhoneNumberFormat());

            builder.Entity<Customer>().HasData(stock.GenerateBetween(50, 50));
        }
    }
}
