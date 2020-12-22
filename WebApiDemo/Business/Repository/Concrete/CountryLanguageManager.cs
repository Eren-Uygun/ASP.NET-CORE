using System;
using System.Collections.Generic;
using System.Text;
using Business.BaseRepository.Concrete;
using Business.Repository.Abstract;
using DataAccess.Context;
using Entities.Entity;

namespace Business.Repository.Concrete
{
   public class CountryLanguageManager:BaseManager<CountryLanguage>,ICountryLanguageService
    {
        public CountryLanguageManager(ProjectContext context) : base(context)
        {
        }
    }
}
