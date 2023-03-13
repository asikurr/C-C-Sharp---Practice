// See https://aka.ms/new-console-template for more information

using EnumExample;
using System.Text;

User user = new User();
user.Name = "Asikur Rahaman ";
user.Email = "asikur.cse@gmail.com";
user.UserStatus = UserStatus.Verifyed;

int a = (int)UserStatus.Verifyed;
Console.WriteLine(UserStatus.Verifyed);


DateTime dateTime1 = DateTime.Now;
DateTime d = dateTime1.AddHours(-6);
var d1 = dateTime1.DayOfWeek;
DateTime dateTime3 = DateTime.UtcNow;
DateTime dateTime2 = new DateTime(1994,11,21);
Console.WriteLine(dateTime1);
Console.WriteLine(dateTime2);
Console.WriteLine(dateTime3);

//==============================================

StringBuilder stringBuilder = new StringBuilder();
stringBuilder.Append("Asikur");
stringBuilder.Append(" ");
stringBuilder.Append("Rahaman");
stringBuilder[6] = 'X';
string name = stringBuilder.ToString();
Console.WriteLine(name);
string hello = "Hello World.";
Console.WriteLine(hello.Substring(0,5));
foreach (char c in hello)
{
    Console.WriteLine(c);
}


