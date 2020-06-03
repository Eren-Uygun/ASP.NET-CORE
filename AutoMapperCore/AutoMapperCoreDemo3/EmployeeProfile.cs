using AutoMapper;
using AutoMapperCoreDemo3.Models;
using AutoMapperCoreDemo3.ModelsVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace AutoMapperCoreDemo3
{
    public class EmployeeProfile:Profile
    {
        public EmployeeProfile()
        {

            CreateMap<Employees,EmployeeVM>()
                .ForMember(desc=>desc.FullName,opt=>opt.MapFrom(src=>src.FullName))
                .ForMember(desc=>desc.BirthDate,opt=>opt.MapFrom(src=>src.BirthDate))
                .ForMember(desc=>desc.Title,opt=>opt.MapFrom(src=>src.Title))
                ;
        }
    }
}
