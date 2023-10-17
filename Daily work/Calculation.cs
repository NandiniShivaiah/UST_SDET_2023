using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace basic_program
{
    internal class Calculation
    {
        double num1, num2, ans;
        public void add(int num1, int num2)
        {
            ans = num1 + num2;
            Console.WriteLine(ans);

        }
    }
}
