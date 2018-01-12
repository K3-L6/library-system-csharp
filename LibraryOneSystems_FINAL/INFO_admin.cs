using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace INFO
{
    public static class admin
    {
        static string User;
        public static string Username
        {
            get { return User; }
            set { User = value; }
        }

        static string Pass;
        public static string Password
        {
            get { return Pass; }
            set { Pass = value; }
        }

        static string lastN;
        public static string Lastname
        {
            get { return lastN; }
            set { lastN = value; }
        }

        static string firstN;
        public static string Firstname
        {
            get { return firstN; }
            set { firstN = value; }
        }

        static string email;
        public static string Email
        {
            get { return email; }
            set { email = value; }
        }

    }
}
