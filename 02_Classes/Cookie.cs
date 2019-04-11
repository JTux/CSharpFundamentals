using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Classes
{
    public class Cookie
    {
        public int ArmCount { get; set; }
        public int LegCount { get; set; }
        public double SugarAmount { get; set; }
        public double FlourAmount { get; set; }
        public string CookieName { get; set; }
        public DateTime DateBaked { get; set; }
        public bool HasNuts { get; set; }

        public Cookie()
        {

        }

        public Cookie(DateTime dateBaked)
        {
            DateBaked = dateBaked;
        }
    }
}
