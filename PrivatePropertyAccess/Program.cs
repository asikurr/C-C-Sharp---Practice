// See https://aka.ms/new-console-template for more information

using PrivatePropertyAccess;
using System.Reflection;

Item Item = new Item();
var PrivateInt = Item.GetType().GetProperty("PrivateInt", BindingFlags.Instance | BindingFlags.NonPublic);
//PrivateInt.SetValue(Item, 100);
int value =(int) PrivateInt.GetValue(Item);
Console.WriteLine(value);