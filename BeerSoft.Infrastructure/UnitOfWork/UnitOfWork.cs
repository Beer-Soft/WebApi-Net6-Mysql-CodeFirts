﻿using BeerSoft.Core.Interfaces;
using BeerSoft.Infrastructure.Data;
using BeerSoft.Infrastructure.Repositories;
using Core.Interfaces;
using Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerSoft.Infrastructure.UnitOfWork
{
    public class UnitOfWork:  IUnitOfWork,IDisposable
    {
        private readonly TiendaContext _context;
        private IProductoRepository _productos;
        private IMarcaRepository _marcas;
        private ICategoriaRepository _categorias;
        private IRolRepository _roles;
        private IUsuarioRepository _usuarios;
        private IMenuRepository _menus;

        public UnitOfWork(TiendaContext context)
        {
            _context = context;
        }

        public ICategoriaRepository Categorias
        {
            get
            {
                if (_categorias == null)
                {
                    _categorias = new CategoriaRepository(_context);
                }
                return _categorias;
            }
        }

        public IMarcaRepository Marcas
        {
            get
            {
                if (_marcas == null)
                {
                    _marcas = new MarcaRepository(_context);
                }
                return _marcas;
            }
        }

        public IProductoRepository Productos
        {
            get
            {
                if (_productos == null)
                {
                    _productos = new ProductoRepository(_context);
                }
                return _productos;
            }
        }
        public IRolRepository Roles
        {
            get
            {
                if (_roles == null)
                {
                    _roles = new RolRepository(_context);
                }
                return _roles;
            }
        }


        public IUsuarioRepository Usuarios
        {
            get
            {
                if (_usuarios == null)
                {
                    _usuarios = new UsuarioRepository(_context);
                }
                return _usuarios;
            }
        }

        public IMenuRepository Menus
        {
            get
            {
                if(_menus == null)
                {
                    _menus = new MenuRepository(_context);
                }

                return _menus;
            }
        }

        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
