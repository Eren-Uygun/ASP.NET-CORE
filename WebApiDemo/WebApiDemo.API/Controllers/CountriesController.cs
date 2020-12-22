using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.BaseRepository.Abstract;
using Business.Repository.Abstract;
using DataAccess.Context;
using Entities.Entity;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace WebApiDemo.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountriesController : ControllerBase
    {
        private IBaseService<Country> _countryBaseService;
        private ProjectContext _context;
        public CountriesController(IBaseService<Country> baseService, ProjectContext context)
        {
            _countryBaseService = baseService;
            _context = context;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var country = _countryBaseService.GetAll();
            return Ok(country);
            //try
            //{
            //    var country = _countryBaseService.GetAll();
            //    return Ok(country);
            //}
            //catch (Exception e)
            //{
            //    return BadRequest(e.Message);
            //}
        }

        [HttpGet("getone")]
        public IActionResult GetById(string code)
        {

            try
            {
                var country = _countryBaseService.GetByCode(code);
                return Ok(country);
            }
            catch (Exception e)
            {
                return Ok(e.Message);
            }
        }


        [HttpPost("add")]
        public IActionResult Add([FromBody]Country country)
        {
            try
            {
                _countryBaseService.Add(country);
                _countryBaseService.Save();
                return Ok(country);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }

        }

        [HttpPut("update")]
        public IActionResult Update([FromBody]Country model)
        {
            try
            {

                var countryModel = _countryBaseService.GetByCode(model.Code);
                countryModel.Code = model.Code;
                countryModel.Name = model.Name;
                countryModel.Continent = model.Continent;
                countryModel.Region = model.Region;
                countryModel.SurfaceArea = model.SurfaceArea;
                countryModel.IndepYear = model.IndepYear;
                countryModel.Population = model.Population;
                countryModel.LifeExpectancy = model.LifeExpectancy;
                countryModel.GNP = model.GNP;
                countryModel.GNPOld = model.GNPOld;
                countryModel.LocalName = model.LocalName;
                countryModel.GovernmentForm = model.GovernmentForm;
                countryModel.HeadOfState = model.HeadOfState;
                countryModel.Capital = model.Capital;
                countryModel.Code2 = model.Code2;

                _countryBaseService.Update(countryModel);
                _countryBaseService.Save();
                return Ok(countryModel);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }

        }

        [HttpDelete]
        public IActionResult Delete(string code)
        {
            try
            {
                var country = _countryBaseService.GetByCode(code);
                _countryBaseService.Delete(country);
                _countryBaseService.Save();
                return Ok();

            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }




    }
}
