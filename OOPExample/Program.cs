// See https://aka.ms/new-console-template for more information
using OOPExample;

Console.WriteLine("Hello, World!");

WaterBottel waterBottel1 = new WaterBottel(50);

Console.WriteLine(waterBottel1.Capacity);
Console.WriteLine(waterBottel1.Color);
Console.WriteLine(waterBottel1._material);


WaterBottel waterBottel = new WaterBottel(14, "red","polimar");
waterBottel.AddWather(50);
waterBottel.Capacity = 14;

Console.WriteLine(waterBottel.Capacity);
Console.WriteLine(waterBottel._material);
