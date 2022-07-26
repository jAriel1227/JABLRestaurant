using RestaurantAPI.Core.Domain.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using RestauranteAPI.Core.Domain.Entities;

namespace RestaurantAPI.Infrastructure.Persistence.Contexts
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options): base(options)
        {

        }

        public DbSet<Ingredients> Ingredient { get; set; }
        public DbSet<Oders> Oder { get; set; }
        public DbSet<OdersStatus> OdersStatuses { get; set; }
        public DbSet<Plates> Plate { get; set; }
        public DbSet<PlatesCategory> PlatesCategories { get; set; }
        public DbSet<Tables> Table { get; set; }
        public DbSet<TablesStatus> TablesStatuses { get; set; }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            foreach (var entry in ChangeTracker.Entries<AuditableBaseEntity>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.Created = DateTime.Now;
                        entry.Entity.CreatedBy = "DefaultAppUser";
                        break;
                    case EntityState.Modified:
                        entry.Entity.Modified = DateTime.Now;
                        entry.Entity.ModifiedBy = "DefaultAppUser";
                        break;
                }
            }

            return base.SaveChangesAsync(cancellationToken);
        }



        protected override void OnModelCreating(ModelBuilder modelbuilder) {
            //Fluent API

            modelbuilder.HasDefaultSchema("RestaurantAPI");
            #region Tables
            modelbuilder.Entity<Ingredients>().ToTable("Ingredients");
            modelbuilder.Entity<Oders>().ToTable("Orders");
            modelbuilder.Entity<OdersStatus>().ToTable("OrdersStatus");
            modelbuilder.Entity<Plates>().ToTable("Plates");
            modelbuilder.Entity<PlatesCategory>().ToTable("PlatesCategory");
            modelbuilder.Entity<Tables>().ToTable("Tables");
            modelbuilder.Entity<TablesStatus>().ToTable("TablesStatus");
            #endregion

            #region Primary Key
            modelbuilder.Entity<Ingredients>().HasKey(ingredient => ingredient.Id);
            modelbuilder.Entity<Oders>().HasKey(order => order.Id);
            modelbuilder.Entity<OdersStatus>().HasKey(oStatus => oStatus.Id);
            modelbuilder.Entity<Plates>().HasKey(plates => plates.Id);
            modelbuilder.Entity<PlatesCategory>().HasKey(PCategory => PCategory.Id);
            modelbuilder.Entity<Tables>().HasKey(tables => tables.Id);
            modelbuilder.Entity<TablesStatus>().HasKey(tStatus => tStatus.Id);
            #endregion

            #region RelationShips

            modelbuilder.Entity<Oders>()
               .HasMany(order => order.Plates)
               .WithOne(plates => plates.Oders)
               .HasForeignKey(plates => plates.IdOrders);

            modelbuilder.Entity<PlatesCategory>()
                .HasMany(pCategory => pCategory.PlatesC)
                .WithOne(plates => plates.PlatesCategory)
                .HasForeignKey(plates => plates.IdCategory);

            modelbuilder.Entity<Plates>()
                .HasMany(plates => plates.Ingredients)
                .WithOne(ingredient => ingredient.Plates)
                .HasForeignKey(ingredient => ingredient.PlateId);

            modelbuilder.Entity<TablesStatus>()
                .HasMany(tStatus => tStatus.Tables)
                .WithOne(tables => tables.TablesStatus)
                .HasForeignKey(tables => tables.StateId);

            modelbuilder.Entity<OdersStatus>()
                .HasMany(oStatus => oStatus.Oders)
                .WithOne(order => order.OdersStatus)
                .HasForeignKey(order => order.StateId);

            #endregion

            #region Seeds
            modelbuilder.Entity<OdersStatus>().HasData(
                new() { Id = 1, Name = "In process", CreatedBy = "DefaultDatabaseAdministrator", Created = DateTime.Now },
                new() { Id = 2, Name = "Completed", CreatedBy = "DefaultDatabaseAdministrator", Created = DateTime.Now });

            modelbuilder.Entity<PlatesCategory>().HasData(
                new() { Id = 1, Name = "Entry", CreatedBy = "DefaultDatabaseAdministrator", Created = DateTime.Now },
                new() { Id = 2, Name = "Main course", CreatedBy = "DefaultDatabaseAdministrator", Created = DateTime.Now },
                new() { Id = 3, Name = "Dessert", CreatedBy = "DefaultDatabaseAdministrator", Created = DateTime.Now },
                new() { Id = 4, Name = "Beverage", CreatedBy = "DefaultDatabaseAdministrator", Created = DateTime.Now });

            modelbuilder.Entity<TablesStatus>().HasData(
                new() { Id = 1, Name = "Available", CreatedBy = "DefaultDatabaseAdministrator", Created = DateTime.Now },
                new() { Id = 2, Name = "In care process", CreatedBy = "DefaultDatabaseAdministrator", Created = DateTime.Now },
                new() { Id = 3, Name = "Serviced", CreatedBy = "DefaultDatabaseAdministrator", Created = DateTime.Now });
            #endregion

            #region Properties

            #region Ingredients

            modelbuilder.Entity<Ingredients>()
               .Property(x => x.IngredientName)
               .IsRequired();

            modelbuilder.Entity<Ingredients>()
               .Property(x => x.PlateId)
               .IsRequired();
            #endregion

            #region Orders

            modelbuilder.Entity<Oders>()
               .Property(x => x.IdTable)
               .IsRequired();

            modelbuilder.Entity<Oders>()
               .Property(x => x.IdPlates)
               .IsRequired();

            modelbuilder.Entity<Oders>()
               .Property(x => x.IdTable)
               .IsRequired();

            modelbuilder.Entity<Oders>()
               .Property(x => x.StateId)
               .IsRequired();
            #endregion
                        
            #region Plates

            modelbuilder.Entity<Plates>()
               .Property(x => x.PlateName)
               .IsRequired();

            modelbuilder.Entity<Plates>()
               .Property(x => x.PlatePrice)
               .IsRequired();

            modelbuilder.Entity<Plates>()
               .Property(x => x.givePeple)
               .IsRequired();

            modelbuilder.Entity<Plates>()
               .Property(x => x.IdOrders)
               .IsRequired();

            modelbuilder.Entity<Plates>()
               .Property(x => x.IdCategory)
               .IsRequired();

            #endregion

            #region Tables

            modelbuilder.Entity<Tables>()
               .Property(x => x.Numberofpeople)
               .IsRequired();

            modelbuilder.Entity<Tables>()
               .Property(x => x.StateId)
               .IsRequired();

            #endregion

            #endregion





        }
    }
}
