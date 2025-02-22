﻿using BeerSoft.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerSoft.Infrastructure.Data.Configuration
{
    public class ProductoConfiguration : IEntityTypeConfiguration<Producto>
    {
        public void Configure(EntityTypeBuilder<Producto> builder)
        {
            builder.ToTable("Producto");
            builder.Property(p => p.Id)
                    .IsRequired();
            builder.Property(p => p.Nombre)
                    .IsRequired()
                    .HasMaxLength(100);
            builder.Property(p => p.Precio)
                    .HasColumnType("decimal(18,2)");

            builder.HasOne(p => p.Marca)
                    .WithMany(p => p.Productos)
                    .HasForeignKey(p => p.MarcaId);

            builder.HasOne(p => p.Categoria)
                    .WithMany(p => p.Productos)
                    .HasForeignKey(p => p.CategoriaId);



        }
    }
}
