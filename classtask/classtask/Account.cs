using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classtask
{
    internal class Account
    {
        public string Username;
        public string Password;



        public void Login(string username, string password)
        {


            if (username == Username && password == Password)
            {
                Console.WriteLine("giris ugurludur");
            }
            else
            {
                Console.WriteLine("ad ve ya password yanlisdir");
            }




        }
    }
}
