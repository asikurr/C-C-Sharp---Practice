// See https://aka.ms/new-console-template for more information
using System.Globalization;

string name1 = "Jack Smith";
string name2 = "John Doe";

// Get position of character after the space character.
int index1 = name1.IndexOf(" ");
index1 = index1 < 0 ? 0 : ++index1;

int index2 = name2.IndexOf(" ");
index2 = index2 < 0 ? 0 : ++index2;

int length = Math.Max(name1.Length, name2.Length);

Console.WriteLine("Sorted alphabetically by last name:");
if (String.Compare(name1, index1, name2, index2, length,
                   new CultureInfo("en-US"), CompareOptions.IgnoreCase) < 0)
    Console.WriteLine("{0}\n{1}", name1, name2);
else
    Console.WriteLine("{0}\n{1}", name2, name1);
