// See https://aka.ms/new-console-template for more information
using PartialClassEx;
using System.Reflection;

Car car = new Car("Roll Royel");
car.StartCar();
//Console.WriteLine(car._model);
var carMod = car.GetType().GetProperty("Model", BindingFlags.Instance | BindingFlags.NonPublic);
string? newVal =(string) carMod.GetValue(car);
Console.WriteLine(newVal);
