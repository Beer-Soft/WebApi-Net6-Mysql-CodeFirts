using BeerSoft.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerSoft.Infrastructure.Data.Configuration
{
    public class MenuConfiguration: IEntityTypeConfiguration<Menu>
    {
        public void Configure(EntityTypeBuilder<Menu> builder)
        {
            builder.ToTable("Menu");
            builder.Property(p => p.Id)
                    .IsRequired();
            builder.Property(p => p.Icono)
                    .HasMaxLength(400);
            builder.Property(p => p.Titulo)
                    .IsRequired()
                    .HasMaxLength(100);
            builder.Property(p => p.Roles)
                    .IsRequired()
                    .HasMaxLength(400);
            builder.Property(p => p.MenuIdPadre)
                    .IsRequired();

            //builder.Property(p => p.Activo)
            //    .HasColumnType("BIT")
            //    .HasConversion<bool>();

           

        }
    }
}
