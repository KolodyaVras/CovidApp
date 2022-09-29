using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovidApp
{
    class Certificates
    {
        private string SertNum;
        private string DateStart;
        private string DateEnd;
        private string Type;
        private int User;

        public Certificates(string sn, string ds, string de, string t, int u)
        {
            sn = SertNum;
            ds = DateStart;
            de = DateEnd;
            t = Type;
            u = User;
        }
    }
}
