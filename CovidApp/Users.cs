using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovidApp
{
    public class Users
    {
        private string Name;
        private string Passport;
        private string Depart;
        private string Sector;
        private string BirthDate;
        private char Gender;
        private string Qualification;
        private bool Admin;
        private string Email;

        public Users(string n, string p, string d, string s, string bd, char g, string q, bool a, string email)
        {
            n = Name;
            p = Passport;
            d = Depart;
            s = Sector;
            bd = BirthDate;
            g = Gender;
            q = Qualification;
            a = Admin;
            email = Email;
        }
    }
}
