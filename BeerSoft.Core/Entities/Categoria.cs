using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerSoft.Core.Entities
{
    public class Categoria:BaseEntity
    {
       
        public string Nombre { get; set; }
        public ICollection<Producto> Productos { get; set; }
    }
}
