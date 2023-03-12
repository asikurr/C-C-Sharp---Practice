// See https://aka.ms/new-console-template for more information
using AbastractAndInheritanceExample;

Electronics electronics = new Electronics("Sony Laptop Z1101");
electronics.Brand = "Sony";
electronics.Description = "This product describe about sony laptop all about Description";
string description = electronics.ShortendDescription();

Console.WriteLine(description);

Book book = new Book("Mechine Learning", 100);
book.Author = "Rokib Hasan";
book.Description = "This book is all about for Al";
Console.WriteLine(book.ShortendDescription());

Bus transport = new Bus();
transport.StartEngine();
