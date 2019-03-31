using EscolaX.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaX.Infra.Data.EntityConfig
{
    public class UserConfig : EntityTypeConfiguration<User>
    {
        public UserConfig()
        {
            HasKey(m => m.UserId);

            Property(m => m.Name).IsRequired().HasMaxLength(250);
            Property(m => m.Email).IsRequired().HasMaxLength(250);
            Property(m => m.Password).IsRequired().HasMaxLength(50);
            Property(m => m.SecurityAnswer).IsRequired().HasMaxLength(255);
            Property(m => m.SecurityQuestion).IsRequired().HasMaxLength(255);

        }
    }
}
