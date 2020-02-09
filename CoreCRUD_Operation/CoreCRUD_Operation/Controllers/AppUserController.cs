using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreCRUD_Operation.DAL.ORM.Context;
using CoreCRUD_Operation.DAL.ORM.Entity;
using CoreCRUD_Operation.Models.DTO;
using Microsoft.AspNetCore.Mvc;

namespace CoreCRUD_Operation.Controllers
{
    public class AppUserController : Controller
    {
        private readonly ProjectContext _context;
        public AppUserController(ProjectContext context)
        {
            _context = context;
        }
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(AppUserDTO app)
        {
            if (ModelState.IsValid)
            {
                AppUser model = new AppUser();
                model.FirstName = app.FirstName;
                model.LastName = app.LastName;
                model.Email = app.Email;
                model.Password = app.Password;
                model.UserName = app.UserName;
                _context.Add(model);
                _context.SaveChanges();
                return RedirectToAction("Add");
            }
            else
            {
                return View();
            }
           
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            AppUser appUser =_context.Users.FirstOrDefault(x=>x.ID == id);
            AppUserDTO model = new AppUserDTO();
            model.ID = appUser.ID;
            model.FirstName = appUser.FirstName;
            model.LastName = appUser.LastName;
            model.Email = appUser.Email;
            model.Password = appUser.Password;
            model.UserName = appUser.UserName;
            return View(model);

        }
        [HttpPost]
        public IActionResult Edit(AppUserDTO model)
        {
            if (ModelState.IsValid)
            {
                AppUser appUser = new AppUser();
                appUser.FirstName = model.FirstName;
                appUser.LastName = model.LastName;
                appUser.Email = model.Email;
                appUser.Password = model.Password;
                appUser.UserName = model.UserName;
                appUser.Status = Status.Modified;
                appUser.ModifiedDate = DateTime.Now;
                return RedirectToAction("List");
            }
            else
            {
                return View();
            }
            

        }

        public IActionResult Remove(int id)
        {
            AppUser appUser = _context.Users.FirstOrDefault(x=>x.ID == id);
            appUser.Status = Status.Passive;
            appUser.RemovedDate = DateTime.Now;
            _context.SaveChanges();
            return RedirectToAction("List");
        }

        public IActionResult List()
        {
            IEnumerable<AppUser> model = _context.Users.Where(x => x.Status == Status.Active || x.Status == Status.Modified).ToList();
            return View("List", model);
           
        }

    }
}