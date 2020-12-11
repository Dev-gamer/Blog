using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogLab.Web.Account
{
    public class ApplicationUserLogin
    {
        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
        [System.ComponentModel.DataAnnotations.MinLength(5,ErrorMessage= "Must be at least 5-20 characteres")]
        [System.ComponentModel.DataAnnotations.MaxLength(20, ErrorMessage = "Must be at least 5-20 characteres")]

        public string Username { get; set; }
        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Password is required")]
        [System.ComponentModel.DataAnnotations.MinLength(10, ErrorMessage = "Must be at least 10-50 characteres")]
        [System.ComponentModel.DataAnnotations.MaxLength(50, ErrorMessage = "Must be at least 10-50 characteres")]


        public string Password { get; set; }
    }
}
