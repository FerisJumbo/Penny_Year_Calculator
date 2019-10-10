using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Penny_Year_Calculator
{
    public class Penny
    {
        public int Year { get; set; }
        public bool IsOver2000 { get; set; }

        public Penny(int year)
        {
            this.Year = year;
            Over2000();
        }

        public void Over2000()
        {
            if (this.Year >= 2000)
            {
                this.IsOver2000 = true;
            }
            else { }
        }
    }
}
