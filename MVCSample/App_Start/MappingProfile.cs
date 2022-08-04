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
            //Domain to Dto
            Mapper.CreateMap<Customers, CustomerDto>();
            Mapper.CreateMap<Movies, MovieDto>();
            Mapper.CreateMap<MembershipType, MembershipTypeDto>();
            Mapper.CreateMap<Genre, GenreDto>();

            //Dto to Domain
            Mapper.CreateMap<CustomerDto, Customers>()
                .ForMember(c => c.Id, opt => opt.Ignore());
            Mapper.CreateMap<MovieDto, Movies>()
                .ForMember(m => m.Id, opt => opt.Ignore());
        }
    }
}