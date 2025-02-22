﻿using BeerSoft.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerSoft.Core.Interfaces
{
    public interface IProductoRepository : IGenericRepository<Producto>
    {
        Task<IEnumerable<Producto>> GetProductosMasCaros(int cantidad);
    }
}
