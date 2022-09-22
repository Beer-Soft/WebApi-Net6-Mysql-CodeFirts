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
    public class MenuRepository: GenericRepository<Menu>, IMenuRepository
    {
        public MenuRepository(TiendaContext context) : base(context)
        {
        }
    }
}
