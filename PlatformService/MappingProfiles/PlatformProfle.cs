using AutoMapper;
using PlatformService.Dtos;
using PlatformService.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlatformService.MappingProfiles
{
    public class PlatformProfle : Profile
    {
        public PlatformProfle()
        {
            // source -> target
            CreateMap<Platform, PlatformReadDto>();
            CreateMap<PlatformCreateDto, Platform>();
        }
    }
}
