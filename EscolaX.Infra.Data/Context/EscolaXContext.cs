using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using EscolaX.Domain.Entities;
using System.Data.Entity.ModelConfiguration.Conventions;
using EscolaX.Infra.Data.EntityConfig;

namespace EscolaX.Infra.Data.Context
{
    public class EscolaXContext : DbContext
    {
        public EscolaXContext()
            :base("EscolaXDDD")
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            modelBuilder.Properties()
                .Where(m => m.Name == m.ReflectedType.Name + "Id")
                .Configure(m => m.IsKey());

            modelBuilder.Properties<string>()
                .Configure(m => m.HasColumnType("nvarchar"));

            modelBuilder.Properties<string>()
                .Configure(m => m.HasMaxLength(100));

            modelBuilder.Configurations.Add(new UserConfig());
            modelBuilder.Configurations.Add(new StudentConfig());

        }
        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(m => m.Entity.GetType().GetProperty("IncludeDate") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("IncludeDate").CurrentValue = DateTime.Now;
                }

                if (entry.State == EntityState.Modified)
                {
                    entry.Property("IncludeDate").IsModified = false;
                }               
            }
            return base.SaveChanges();
        }

    }
}
