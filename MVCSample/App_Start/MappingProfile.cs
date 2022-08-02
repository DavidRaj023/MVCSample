using AutoMapper;
using MVCSample.Dtos;
using MVCSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCSample.App_Start
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Customers, CustomerDto>();
            Mapper.CreateMap<CustomerDto, Customers>()
                .ForMember(c => c.Id, opt => opt.Ignore());

            Mapper.CreateMap<Movies, MovieDto>();
            Mapper.CreateMap<MovieDto, Movies>()
                .ForMember(m => m.Id, opt => opt.Ignore());
        }
    }
}