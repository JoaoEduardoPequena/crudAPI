﻿using AutoMapper;
using Domain.Entites;
using Domain.Models;

namespace Application.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CategoriaDTO, Categoria>().ReverseMap();
        }
    }
}
