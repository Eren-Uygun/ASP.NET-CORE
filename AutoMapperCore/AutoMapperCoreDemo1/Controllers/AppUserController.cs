using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapperCoreDemo1.Models;
using AutoMapperCoreDemo1.VM;
using Microsoft.AspNetCore.Mvc;

namespace AutoMapperCoreDemo1.Controllers
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
            var AppUserVM = _mapper.Map<AppUserVM>(AppUser);
            return View(AppUserVM);
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
