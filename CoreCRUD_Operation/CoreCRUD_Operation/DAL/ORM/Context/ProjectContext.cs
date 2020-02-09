using CoreCRUD_Operation.DAL.ORM.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreCRUD_Operation.Models.DTO;

namespace CoreCRUD_Operation.DAL.ORM.Context
{
    public class ProjectContext:DbContext
    {
        public ProjectContext(DbContextOptions<ProjectContext> options):base(options)
        {

        }
        public DbSet<AppUser> Users { get; set; }
        
    }
}
