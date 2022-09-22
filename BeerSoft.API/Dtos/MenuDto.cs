namespace BeerSoft.API.Dtos
{
    public class MenuDto
    {
        public int Id { get; set; }
        public string Icono { get; set; }
        public string Titulo { get; set; }
        public string Url { get; set; }
        public string Roles { get; set; }
        public int MenuIdPadre { get; set; }
        public bool Activo { get; set; }
        public DateTime FechaAlta { get; set; }
    }
}
