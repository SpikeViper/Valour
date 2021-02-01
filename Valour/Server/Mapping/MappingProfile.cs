﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Valour.Server.Planets;
using Valour.Server.Users;
using Valour.Shared.Planets;
using Valour.Shared.Users;

namespace Valour.Server.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Planet, ServerPlanet>();
            CreateMap<ServerPlanet, Planet>();

            CreateMap<User, ServerPlanetUser>();
            CreateMap<ServerPlanetUser, User>();

            CreateMap<User, PlanetUser>();
            CreateMap<PlanetUser, User>();

            CreateMap<PlanetInvite, ClientPlanetInvite>();
        }
    }
}
