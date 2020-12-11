using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogLab.Web.Account
{
    public class ApplicationUserIdentitiy
    {
        public int ApplicationUserId { get; set; }

        public string Username { get; set; }

        public int NormalizedUsername { get; set; }

        public string Email { get; set; }

        public string NormalizedEmail { get; set; }


        public string Fullname { get; set; }

        public string PasswordHash { get; set; }
    }
}
