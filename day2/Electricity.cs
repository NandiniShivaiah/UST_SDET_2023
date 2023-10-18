using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_program
{
    class Electricity
    {
        public int consumernumber, prereading, curreading;
        public string? consumername;

        public Electricity(int consumernumber, int prereading, int curreading, string? consumername)
        {
            this.consumernumber = consumernumber;
            this.prereading = prereading;
            this.curreading = curreading;
            this.consumername = consumername;
        }

        /*public  Electricity()
         {
             consumernumber = 12345;
             consumername = "aa";
             prereading = 9000;
             curreading = 9300;
         }*/

        public double CalculateBill()
        {
            double billamount = 0;
            int reading = curreading - prereading;
            if (reading <= 0)
            {
                billamount = reading * 2.00;
            }
            else if (reading <= 200 && reading >= 101)
            {
                billamount = (100*2) +((reading-100) * 2.5);
            }

            else if (reading <= 401 && reading >= 201)
            {
                billamount = (100 * 2) + (100 * 2.5) * (reading - 200) * 3.5;
            }
            else
            {
                billamount=(100*2)+(100*2.5)+(100*3.5)+((reading-400)*3.5);
            }
            return billamount;

        }
    }


}






