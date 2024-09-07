using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_004_02_09_2024
{
    internal class ApplicationlContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<UserSettings> UsersSettings { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-C317JNM;Database=UserLogin2;Trusted_Connection=True;TrustServerCertificate=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {

            modelBuilder.Entity<User>()
                .HasKey(u => u.UserId);
            modelBuilder.Entity<User>()
                .HasIndex(u => u.UserLogin)
                .IsUnique();
            modelBuilder.Entity<UserSettings>()
                .HasKey(u => u.SettingsId);
            modelBuilder.Entity<User>()
                .HasOne(u => u.Settings)
                .WithOne(s => s.User)
                .HasForeignKey<UserSettings>(us => us.SettingsId)
                .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
