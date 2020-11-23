using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityDemo.Models
{
    public class RegisterEditVM
    {
        [Required]
        public string UserName { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }

        [Required, DataType(DataType.Password)]
        public string Password { get; set; }

        public RegisterEditVM()
        {

        }

        public RegisterEditVM(AppUser user)
        {
            UserName = user.UserName;
            Email = user.Email;
            Password = user.PasswordHash;
        }

    }
}
