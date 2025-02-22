﻿using API.Dtos;
using BeerSoft.API.Dtos;

namespace API.Services;
public interface IUserService
{
    Task<string> RegisterAsync(RegisterDto model);
    Task<DatosUsuarioDto> GetTokenAsync(LoginDto model);
    Task<UsuarioInfoDto> GetInfoUsuario(int id);
    Task<string> AddRoleAsync(AddRoleDto model);
    Task<DatosUsuarioDto> RefreshTokenAsync(string refreshToken);
}
