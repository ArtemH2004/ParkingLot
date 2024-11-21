using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ParkingLotApp.Models;

namespace ParkingLotApp.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<ParkingLot> ParkingLots { get; set; }
        public DbSet<ParkingSpace> ParkingSpaces { get; set; }
        public DbSet<Contract> Contracts { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Guard> Guards { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Contract>()
                .Property(c => c.Amount)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<Driver>()
                .Property(d => d.Salary)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<Guard>()
                .Property(g => g.Salary)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<ParkingSpace>()
                .Property(ps => ps.DailyPrice)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<Client>()
                .HasMany(c => c.Contracts)
                .WithOne(c => c.Client);

            modelBuilder.Entity<Driver>()
                .HasMany(d => d.DeliveredVehicles)
                .WithMany(v => v.Drivers);

            modelBuilder.Entity<Vehicle>()
                .HasOne(v => v.Client)
                .WithOne(c => c.Vehicle)
                .HasForeignKey<Vehicle>(v => v.ClientId);

            // Конфигурация отношений один-к-одному
            modelBuilder.Entity<ApplicationUser>()
                .HasOne(a => a.Client)
                .WithOne(c => c.ApplicationUser)
                .HasForeignKey<Client>(c => c.ApplicationUserId); // Здесь укажите имя вашего свойства внешнего ключа
        }
    }
}
