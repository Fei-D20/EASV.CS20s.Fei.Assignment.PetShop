using System;
using System.Collections.Generic;
using EASV.CS20s.Fei.Assignment.PetShop.Core.Models;
using EASV.CS20s.Fei.Assignment.PetShop.EFSql.Entities;
using Microsoft.EntityFrameworkCore;

namespace EASV.CS20s.Fei.Assignment.PetShop.EFSql
{
    public class PetShopApplicationContext : DbContext
    {
        public PetShopApplicationContext (DbContextOptions<PetShopApplicationContext> opt) : base(opt){}


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pet>()
                .HasOne(p => p.Owner)
                .WithMany(o => o.Pets)
                .OnDelete(DeleteBehavior.SetNull);
            modelBuilder.Entity<Pet>()
                .HasOne(p => p.PetType)
                .WithMany(pt => pt.Pets)
                .OnDelete(DeleteBehavior.SetNull);

            /*
             * This part is how to insert 1000 random record in the data base
             */

            var random = new Random(); 
            var names = new List<string>{"AAA", "BBB", "CCC"};

            
            for (int i = 1; i < 1000; i++) // for loop start at 1 until 999
            {
                var petName = $"{names[random.Next(0,3)]}{i}"; // make the random name + loop index
                        // the list names with random index 
                modelBuilder.Entity<PetEntity>() // use modelBuilder make the data
                    .HasData(new PetEntity()
                    {
                        Id = i,
                        Name = petName + i
                    });
            }
            

        }

        public DbSet<PetEntity> Pets { get; set; }
        public DbSet<PetTypeEntity> PetTypes { get; set; } 
        public DbSet<OwnerEntity> Owners { get; set; }
        
        
    }
}