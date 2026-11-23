using Lab2_Part3.Models;
using Microsoft.EntityFrameworkCore;

namespace Lab2_Part3;

public class CodeFirstContext : DbContext
{
    public DbSet<Area> Areas { get; set; }
    public DbSet<Street> Streets { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // Указываем имя НОВОЙ базы данных (например, HospitalCodeFirstDb)
        optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=HospitalCodeFirstDb;Username=postgres;Password=admin");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // 1. Настройка связи один-ко-многим
        modelBuilder.Entity<Street>()
            .HasOne(s => s.Area)
            .WithMany(a => a.Streets)
            .HasForeignKey(s => s.AreaId)
            .OnDelete(DeleteBehavior.Cascade);

        // 2. Стратегия инициализации начальных данных (Data Seeding)
        modelBuilder.Entity<Area>().HasData(
            new Area { Id = 1 },
            new Area { Id = 2 }
        );

        modelBuilder.Entity<Street>().HasData(
            new Street { Id = 1, Name = "ул. Ленина", AreaId = 1 },
            new Street { Id = 2, Name = "пр. Мира", AreaId = 1 },
            new Street { Id = 3, Name = "ул. Гагарина", AreaId = 2 }
        );
    }
}
