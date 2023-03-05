// See https://aka.ms/new-console-template for more information
using OOPExample;

Console.WriteLine("Hello, World!");

WaterBottel waterBottel1 = new WaterBottel();

Console.WriteLine(waterBottel1.Capacity);
Console.WriteLine(waterBottel1.Color);

WaterBottel waterBottel = new WaterBottel(14, "red");
waterBottel.AddWather(50);
waterBottel.Capacity = 14;

Console.WriteLine(waterBottel.Capacity);
