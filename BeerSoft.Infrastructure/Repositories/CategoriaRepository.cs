using BeerSoft.Core.Entities;
using BeerSoft.Core.Interfaces;
using BeerSoft.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerSoft.Infrastructure.Repositories
{
    public class CategoriaRepository: GenericRepository<Categoria>, ICategoriaRepository
    {
        public CategoriaRepository(TiendaContext context) : base(context)
        {
        }
    }
}
