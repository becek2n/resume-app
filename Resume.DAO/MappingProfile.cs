using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Resume.DTO.Request;
using Resume.Repositories.Models;

namespace Resume.DAO
{
    public class MappingProfile : Profile
    {
        public MappingProfile() { 
        
            CreateMap<Profiles, ProfileRequest>();

        }

    }
}
