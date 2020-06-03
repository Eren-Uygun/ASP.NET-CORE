using AutoMapper;
using AutoMapperCoreDemo2.Models;
using AutoMapperCoreDemo2.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace AutoMapperCoreDemo2
{
    public class AppUserProfile:Profile
    {
        public AppUserProfile()
        {
            CreateMap<AppUser,AppUserVM>()
              .ForMember(dest=>dest.FName
              ,opt=>opt.MapFrom(src=>src.FirstName))
              .ForMember(dest=>dest.LName
              ,opt=>opt.MapFrom(src=>src.LastName)).ReverseMap();
            
            

        }
    }
}
