using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogLab.Web.Account
{
    public class ApplicationUser
    {
        public int ApplicationUserId { get; set; }


        public string Username { get; set; }

        public string Fullname { get; set; }

        public string Email { get; set; }

        public string Token { get; set; }




    }
}
