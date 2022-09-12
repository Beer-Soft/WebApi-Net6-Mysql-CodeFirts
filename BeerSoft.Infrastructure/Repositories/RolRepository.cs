using BeerSoft.Infrastructure.Data;
using BeerSoft.Infrastructure.Repositories;
using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;
namespace Infrastructure.Repositories;

public class RolRepository : GenericRepository<Rol>, IRolRepository
{
    public RolRepository(TiendaContext context) : base(context)
    {
    }
}
