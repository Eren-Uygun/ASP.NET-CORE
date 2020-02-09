using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreCRUD_Operation.DAL.ORM.Entity
{
    public class AppUser:BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Email { get; set; }
        public string Password { get; set; }
        public string UserName  { get; set; }
    }
}
