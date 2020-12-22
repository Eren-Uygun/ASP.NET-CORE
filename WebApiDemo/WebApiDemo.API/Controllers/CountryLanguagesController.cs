using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.BaseRepository.Abstract;
using Entities.Entity;

namespace WebApiDemo.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryLanguagesController : ControllerBase
    {
        private readonly IBaseService<CountryLanguage> _baseService;
        public CountryLanguagesController(IBaseService<CountryLanguage> baseService)
        {
            _baseService = baseService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var language = _baseService.GetAll();
            return Ok(language);
        }
    }
}
