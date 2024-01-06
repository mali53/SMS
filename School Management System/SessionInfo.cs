using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management_System
{
    internal class SessionInfo
    {
        public static string LoggedInUserEmail { get; set; }


        public static void SetLoggedInUserEmail(string email)
        {
            LoggedInUserEmail = email;
        }


    }

}
