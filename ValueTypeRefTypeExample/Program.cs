// See https://aka.ms/new-console-template for more information

using ValueTypeRefTypeExample;

int x = 5;
int y = x;
x = x + 1;
Console.WriteLine($" x = {x}, y =  {y}");

Person person= new Person();
person.Name = "Asikur Rahaman";
person.Age = 28;
person.Child  = new Child() { Age = 18 };

Person person1 = person;
Console.WriteLine($"{person1.Name}   ,  {person1.Age} child {person.Child.Age}");

person.Name = "Uddin";
person.Age = 30;
person.Child.Age = 19;
Console.WriteLine($" person 1 = {person1.Name}   ,  {person1.Age} child {person1.Child.Age}");
