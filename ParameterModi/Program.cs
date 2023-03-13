// See https://aka.ms/new-console-template for more information
using ParameterModi;

Console.WriteLine("Hello, World!");
Addition addition= new Addition();

int result = addition.Sum(6,5);
Console.WriteLine(result);

Console.WriteLine(addition.Sum(2, 5, 4, 7));
Console.WriteLine(addition.Sum(new int[] { 2, 4, 6, 8 }));

int val = 10;
addition.RefKeyWord(ref val);
Console.WriteLine(val);