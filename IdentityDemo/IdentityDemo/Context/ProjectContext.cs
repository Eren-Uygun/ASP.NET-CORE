using IdentityDemo.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityDemo.Context
{
    public class ProjectContext:IdentityDbContext<AppUser>
    {
        public ProjectContext(DbContextOptions<ProjectContext> options):base(options)
        {

        }
    }
}
