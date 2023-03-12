// See https://aka.ms/new-console-template for more information

using InterFaceExample;

IFlyable flyable = new Plan();
flyable.Land();

ITransport t =(ITransport)flyable;
t.StartEngine();
