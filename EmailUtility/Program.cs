// See https://aka.ms/new-console-template for more information
using EmailUtility;

Console.WriteLine("Hello, World!");
EmailStaticUtility.Length = 10;
EmailStaticUtility.SendEmail("Asikur", "asikur.cse@gmail.com", "job cv", "this is simple mail.");