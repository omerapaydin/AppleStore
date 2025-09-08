using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppleStore.Entity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace AppleStore.Data.Concrete.EfCore
{
    public class IdentityContext : IdentityDbContext<ApplicationUser>
    {
        public IdentityContext(DbContextOptions<IdentityContext> options) : base(options)
        {

        }
        public DbSet<Comment> Comments => Set<Comment>();
        public DbSet<Category> Categories => Set<Category>();
        public DbSet<Product> Products => Set<Product>();   
        


         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.ConfigureWarnings(warnings => warnings.Ignore(RelationalEventId.PendingModelChangesWarning));
        }

             

            protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var hasher = new PasswordHasher<ApplicationUser>();

            // Kullanıcılar
            var user1 = new ApplicationUser
            {
                Id = "1",
                UserName = "omerapaydin",
                Email = "info@gmail.com",
                ImageFile = "p1.jpg",
                FullName = "Ömer Apaydın",
                EmailConfirmed = true
            };
            user1.PasswordHash = hasher.HashPassword(user1, "User123!");



            modelBuilder.Entity<ApplicationUser>().HasData(user1);

            // Kategoriler
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, Name = "Telefonlar" },
                new Category { CategoryId = 2, Name = "Bilgisayarlar" },
                new Category { CategoryId = 3, Name = "Aksesuarlar" }
            );

            // Ürünler
            modelBuilder.Entity<Product>().HasData(
            new Product
            {
                ProductId = 1,
                Title = "Apple",
                Description = "Apple HomePod Hoparlör",
                PublishedOn = new DateTime(2024, 1, 1),
                Image = "homepod.jpg",
                Price = 45000,
                IsActive = true,
                UserId = "1",
                CategoryId = 1
            },
            new Product
            {
                ProductId = 2,
                Title = "Apple",
                Description = "Apple Şarj Kablosu Magsafe",
                PublishedOn = new DateTime(2024, 2, 1),
                Image = "magsafe.jpg",
                Price = 55000,
                IsActive = true,
                UserId = "1",
                CategoryId = 1
            },
            new Product
            {
                ProductId = 3,
                Title = "Apple",
                Description = "Apple AirPods Pro 2",
                PublishedOn = new DateTime(2024, 3, 1),
                Image = "airpods-pro-2-hero-select-202409.png",
                Price = 75000,
                IsActive = true,
                UserId = "1",
                CategoryId = 1
            },
            new Product
            {
                ProductId = 4,
                Title = "Apple",
                Description = "Apple AirPods Pro 2",
                PublishedOn = new DateTime(2024, 3, 1),
                Image = "airpods-max.jpeg",
                Price = 75000,
                IsActive = true,
                UserId = "1",
                CategoryId = 2
            },
            new Product
            {
                ProductId = 5,
                Title = "Apple",
                Description = "Apple Key Pro 2",
                PublishedOn = new DateTime(2024, 3, 1),
                Image = "key.jpeg",
                Price = 75000,
                IsActive = true,
                UserId = "1",
                CategoryId = 2
            },
            new Product
            {
                ProductId = 6,
                Title = "Apple",
                Description = "Apple Mouse Pro ",
                PublishedOn = new DateTime(2024, 3, 1),
                Image = "mouse.jpeg",
                Price = 75000,
                IsActive = true,
                UserId = "1",
                CategoryId = 3
            }
        );
        }

    }
}