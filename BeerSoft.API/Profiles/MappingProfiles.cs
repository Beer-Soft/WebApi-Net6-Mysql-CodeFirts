﻿using API.Dtos;
using AutoMapper;
using BeerSoft.API.Dtos;
using BeerSoft.Core.Entities;

namespace BeerSoft.API.Profiles;

public class MappingProfiles : Profile
{

    public MappingProfiles()
    {

        CreateMap<Producto, ProductoDto>()
                .ReverseMap();

        CreateMap<Categoria, CategoriaDto>()
                .ReverseMap();

        CreateMap<Marca, MarcaDto>()
                .ReverseMap();

        CreateMap<Producto, ProductoListDto>()
                .ForMember(dest => dest.Marca, origen => origen.MapFrom(origen => origen.Marca.Nombre))
                .ForMember(dest => dest.Categoria, origen => origen.MapFrom(origen => origen.Categoria.Nombre))
                .ReverseMap()
                .ForMember(origen => origen.Categoria, dest => dest.Ignore())
                .ForMember(origen => origen.Marca, dest => dest.Ignore());

        CreateMap<Producto, ProductoAddUpdateDto>()
                .ReverseMap()
                .ForMember(origen => origen.Categoria, dest => dest.Ignore())
                .ForMember(origen => origen.Marca, dest => dest.Ignore());

        CreateMap<Menu, MenuDto>()
                .ReverseMap();
    }
}

