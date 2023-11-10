using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classtask
{
    internal class Faktorial
    {
        
        public void Factorial(int num)
        { 
            if (num >=0)
            {
                int result = 1;
                for (int i = 1; i <= num; i++) 
                {
                    result*= i;
                }
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Menfi ededin faktoriali hesablanmir");
            }
        }
    }
}
