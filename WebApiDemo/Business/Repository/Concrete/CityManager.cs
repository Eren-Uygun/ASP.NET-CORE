using System;
using System.Collections.Generic;
using System.Text;
using Business.BaseRepository.Abstract;
using Business.BaseRepository.Concrete;
using Business.Repository.Abstract;
using DataAccess.Context;
using Entities.Entity;

namespace Business.Repository.Concrete
{
   public class CityManager:BaseManager<City>,ICityService
    {
        public CityManager(ProjectContext context) : base(context)
        {
        }
    }
}
