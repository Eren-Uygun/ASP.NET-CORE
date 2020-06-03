using AutoMapper;
using AutoMapperCoreDemo1.Models;
using AutoMapperCoreDemo1.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoMapperCoreDemo1
{
    public class AppUserProfile:Profile
    {
        public AppUserProfile()
        {
            CreateMap<AppUser,AppUserVM>();
        }
    }
}
