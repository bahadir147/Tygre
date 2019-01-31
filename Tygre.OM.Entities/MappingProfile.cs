using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using Tygre.OM.Entities.Concrete;
using Tygre.OM.Entities.DtoModels;

namespace Tygre.OM.Entities
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Personel, DTOPersonel>();
        }
    }
}
