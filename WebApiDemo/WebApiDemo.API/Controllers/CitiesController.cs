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
    public class CitiesController : ControllerBase
    {
        private IBaseService<City> _cityService;

        public CitiesController(IBaseService<City> cityService)
        {
            _cityService = cityService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            try
            {
                var cities = _cityService.GetAll();
                return Ok(cities);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            try
            {
                var getcity = _cityService.GetById(id);
                return Ok(getcity);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost("add")]
        public IActionResult Add([FromBody]City model)
        {

            try
            {
                _cityService.Add(model);
                _cityService.Save();
                return Ok(model);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);

            }

        }


        [HttpPut("update")]
        public IActionResult Update([FromBody]City model)
        {
            try
            {
                var city = _cityService.GetById(model.Id);

                city.Id = model.Id;
                city.Name = model.Name;
                city.CountryCode = model.CountryCode;
                city.District = model.District;
                city.Population = model.Population;

                _cityService.Update(city);
                _cityService.Save();
                return Ok(city);
            }
            catch (Exception e)
            {
                
                return BadRequest(e.Message);
            }

        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            try
            {
                var city = _cityService.GetById(id);
                _cityService.Delete(city);
                _cityService.Save();
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
           

        }




    }
}
