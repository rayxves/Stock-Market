using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using api.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace api.Data
{
    public class ApplicationDBContext : IdentityDbContext<AppUser>
    {
        public ApplicationDBContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {
            
        }
        public DbSet<Stock> Stocks { get; set; } //add a new table
        
        public DbSet<Comment> Comments { get; set; }

        public DbSet<Portfolio> Portfolios { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Portfolio>(k => k.HasKey( p => new {p.AppUserId, p.StockId})); //foreign keys

            builder.Entity<Portfolio>()
            .HasOne(x => x.AppUser) //portfolio has an unique one appUser
            .WithMany(x => x.Portfolios) //appUser has many portfolios
            .HasForeignKey(x => x.AppUserId); //appUserId is an foreignKey in Portfolio to appUser

            builder.Entity<Portfolio>()
            .HasOne(x => x.Stock) 
            .WithMany(x => x.Portfolios) 
            .HasForeignKey(x => x.StockId);

            List<IdentityRole> roles = new List<IdentityRole>
            
            {
                new IdentityRole {
                    Name = "Admin",
                    NormalizedName = "ADMIN"
                },
                  new IdentityRole {
                    Name = "User",
                    NormalizedName = "USER"
                }
            };
            builder.Entity<IdentityRole>().HasData(roles);
        }

    }
    }