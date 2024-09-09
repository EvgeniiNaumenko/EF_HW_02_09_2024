using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_004_02_09_2024
{
    internal class ApplicationlContext2 : DbContext
    {
        public DbSet<Company> Companys { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Project> Projects { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-C317JNM;Database=CompanyTest;Trusted_Connection=True;TrustServerCertificate=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Company>()
                .HasKey(c => c.CompanyId);
            modelBuilder.Entity<Employee>()
                .HasKey(e => e.EmployeeId);
            modelBuilder.Entity<Project>()
                .HasKey(p => p.ProjectId);
            modelBuilder.Entity<Employee>()
                .HasOne(e=>e.Company)
                .WithMany(e=>e.Employees)
                .HasForeignKey(e=>e.CompanyId);
            modelBuilder.Entity<Project>()
                .HasMany(e => e.Employees)
                .WithMany(p => p.Projects);
        }
    }
}
