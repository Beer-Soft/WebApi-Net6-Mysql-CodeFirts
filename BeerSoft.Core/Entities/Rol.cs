﻿using BeerSoft.Core.Entities;

namespace Core.Entities;

public class Rol : BaseEntity
{
    public string Nombre { get; set; }
    public ICollection<Usuario> Usuarios { get; set; } = new HashSet<Usuario>();
    public ICollection<UsuariosRoles> UsuariosRoles { get; set; }
}

