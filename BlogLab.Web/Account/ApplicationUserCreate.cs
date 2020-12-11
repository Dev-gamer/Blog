using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogLab.Web.Account
{
    public class ApplicationUserCreate : ApplicationUserLogin
    {
        
        [System.ComponentModel.DataAnnotations.MinLength(10, ErrorMessage = "Must be at least 10-30 characteres")]
        [System.ComponentModel.DataAnnotations.MaxLength(30, ErrorMessage = "Must be at least 10-30 characteres")]
        public string Fullname { get; set; }

        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Email is required")]
        [System.ComponentModel.DataAnnotations.MaxLength(30, ErrorMessage = "can be at most 30 characters")]
        [System.ComponentModel.DataAnnotations.EmailAddress(ErrorMessage = "Invalid email format")]

        public string Email { get; set; }
    }
}
