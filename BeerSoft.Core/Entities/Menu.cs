using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerSoft.Core.Entities
{
    public class Menu : BaseEntity
    {
        public string Icono { get; set; }
        public string Titulo { get; set; }
        public string Url { get; set; }
        public string Roles { get; set; }
        public int MenuIdPadre { get; set; }
        public bool Activo { get; set; }
        public DateTime FechaAlta { get; set; }

    }
}
