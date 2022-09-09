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
    public class MarcaRepository: GenericRepository<Marca>, IMarcaRepository
    {
        public MarcaRepository(TiendaContext context) : base(context)
        {
        }
    }
}
