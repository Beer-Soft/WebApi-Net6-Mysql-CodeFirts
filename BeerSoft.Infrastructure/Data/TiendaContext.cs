﻿using BeerSoft.Core.Entities;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BeerSoft.Infrastructure.Data
{
    public class TiendaContext:DbContext
    {
        public TiendaContext(DbContextOptions options): base(options)
        {

        }

        public DbSet<Producto> Productos { get; set; }
        public DbSet<Marca> Marcas { get; set; } 
        public  DbSet<Categoria>  Categorias { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Rol> Roles { get; set; }

        public DbSet<Menu> Menus { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
