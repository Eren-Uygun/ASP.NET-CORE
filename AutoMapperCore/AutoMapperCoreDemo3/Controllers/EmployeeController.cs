using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapperCoreDemo3.Models;
using AutoMapperCoreDemo3.ModelsVM;
using Microsoft.AspNetCore.Mvc;

namespace AutoMapperCoreDemo3.Controllers
{
    public class EmployeeController : Controller
    {
     
        private readonly IMapper _mapper;
        private readonly ProjectContext _context;
        public EmployeeController(IMapper mapper,ProjectContext context)
        {
            
            _mapper = mapper;
            _context = context;
        }

        public IActionResult Index()
        {
            var value = _context.Employees.FirstOrDefault();

            var ValueVM = _mapper.Map<EmployeeVM>(value);

          return View(ValueVM);
         
        }

    }
}
