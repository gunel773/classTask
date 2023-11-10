// See https://aka.ms/new-console-template for more information
using classtask;
using System.Reflection.Metadata;
using System.Text;

#region task1
//Daxil edilen stringi (Salam necesen) reverse (malaS nesecen) eden method yazin
Console.WriteLine(Text(" Salam necesen "));

string Text(string word)
{
    string result = default;
    StringBuilder texT = new StringBuilder();
    for (int i = word.Length - 1; i >= 0; i--)
    {
        texT.Append(word[i]);
    }
    string[] arr = texT.ToString().Split(" ");
    for (int i = arr.Length - 1; i >= 0; i--)
    {
        result += arr[i] + " ";
    }


    return result;
}
#endregion

#region task2
//Account adinda class yaradib, onun icinde Login methodu yazin. Hemin login methoduna username
//ve password gelecek. Username lorem123 ve password 123456* -a beraberdirse ekrana giriw ugurludur yazilsin,
//eks halda email ve ya password sehvdir cixsin.

Account user = new Account();
Console.WriteLine("Ad daxil edin:");
string username = Console.ReadLine();
Console.WriteLine("Password daxil edin:");
string password = Console.ReadLine();
user.Username = "gnl";
user.Password = "1234";
user.Login(username, password);



#endregion

#region task3
//factorial adinda class yaradin ,
//hemin clasin icinde reqem qebul edib hemin reqemin factorialini hesablayan method yazin.
Faktorial number=new Faktorial();
Console.WriteLine("Eded daxil edin;");
int num = int.Parse(Console.ReadLine());
number.Factorial(num);
#endregion

#region task4
//Calculator adinda class yaradirsiz, hemin classin icinde Calculation metodunuz olur.
//Method 2 parametr qebul edir. 4 emeliyyati (+,-,*,/)hesablayan calculator olacaq.
//Reqemler ve operatorlar console(readline)-dan daxil edilmelidir.
Calculator calculate=new Calculator();
Console.WriteLine("Birinci ededi daxil edin:");
int num1=int.Parse(Console.ReadLine());
Console.WriteLine("Ikinci ededi daxil edin:");
int num2=int.Parse(Console.ReadLine());
Console.WriteLine("Hesablamaq ucun parametr daxil edin:");
string parametr=Console.ReadLine();
calculate.Calculation(num1 , num2, parametr);



#endregion