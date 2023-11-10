using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classtask
{
    internal class Calculator
    {
        public int Num1;
        public int Num2;
        public string Parametr;
        public void Calculation (int num1,int num2, string parametr)

        { 
            Num1 = num1;
            Num2 = num2;
            string result = parametr switch
            {
                "*" => $"{num1 * num2}",
                "/"=> $"{num1 / num2}",
                "+" => $"{num1 + num2}",
                "-" => $"{num1 - num2}",
                _ => "isdenilen parametr daxil edilmiyib"
            };
            Console.WriteLine(result) ;

        }
    }
}
