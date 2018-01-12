using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace INFO
{
    public static class librarian
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

        static string start;
        public static string StartTime
        {
            get { return start; }
            set { start = value; }
        }

        static string end;
        public static string EndTime
        {
            get { return end; }
            set { end = value; }
        }

        static string email;
        public static string Email
        {
            get { return email; }
            set { email = value; }
        }
    }
}
