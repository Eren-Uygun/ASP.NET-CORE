using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapperCoreDemo2.Models;
using AutoMapperCoreDemo2.VM;
using Microsoft.AspNetCore.Mvc;

namespace AutoMapperCoreDemo2.Controllers
{
    public class AppUserController : Controller
    {
        private readonly IMapper _mapper;
        public AppUserController(IMapper mapper)
        {
            _mapper = mapper;
        }
     

        public IActionResult Index()
        {
            var AppUser = GetUserDetails();
            var AppUserViewModel = _mapper.Map<AppUserVM>(AppUser);
            return View(AppUserViewModel);
        }

        private static AppUser GetUserDetails()
        {
            return new AppUser
            {
                ID = Guid.NewGuid(),
                FirstName = "Gordon",
                LastName = "Freeman",
                Email = "Gordon.Freeman@mail.com"
            };
        }
    }
}
