using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Business.BaseRepository.Abstract;
using Business.BaseRepository.Concrete;
using Business.Repository.Abstract;
using DataAccess.Context;
using Entities.Entity;

namespace Business.Repository.Concrete
{
   public class CountryManager:BaseManager<Country>,ICountryService
   {
       private readonly ProjectContext _context;
       public CountryManager(ProjectContext context) : base(context)
       {
           _context = context;
       }


   }
}
