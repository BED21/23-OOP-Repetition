
using Inheritance2;

Fact f = new Fact(134, "John Smith", 199, "Astronomy");

Console.WriteLine($"{f.Pages} pages, written by {f.Author} about {f.Subject}, and the price is {f.Price}");

Console.ReadKey();