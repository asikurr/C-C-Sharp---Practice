// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("Hello , Asikur");

/*int a =  Console.Read();

char c = (char)a;

double b = (float)5.5f;

Console.WriteLine(c);

Console.WriteLine(b); */

string num = Console.ReadLine();
string[] nums = num.Split(',', '*');

for (int i = 0;i < nums.Length; i++)
{
    Console.WriteLine(nums[i]);
}
