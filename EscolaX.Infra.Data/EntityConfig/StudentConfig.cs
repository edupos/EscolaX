using EscolaX.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaX.Infra.Data.EntityConfig
{
    public class StudentConfig : EntityTypeConfiguration<Student>
    {
        public StudentConfig()
        {
            HasKey(m => m.StudentId);

            Property(m => m.Name).IsRequired().HasMaxLength(250);
            Property(m => m.Adress).IsRequired().HasMaxLength(250);
            Property(m => m.Phone).IsRequired().HasMaxLength(30);

            HasRequired(m => m.User)
                .WithMany()
                .HasForeignKey(m => m.UserId);

            

        }
    }
}
