// See https://aka.ms/new-console-template for more information
using RabatStrategien.Model;

PriceCalculator Objekt1 = new PriceCalculator(new NoDiscount());
decimal subtotal = 100m;
Console.WriteLine("No Discount");
Console.WriteLine(Objekt1.calculatePrice(subtotal));
Console.WriteLine("VIP Discount");
PriceCalculator Objekt2 = new PriceCalculator(new VIPDiscount());
Console.WriteLine(Objekt2.calculatePrice(subtotal));
Console.WriteLine("Student Discount");
PriceCalculator Objekt3 = new PriceCalculator(new StudentDiscount());
Console.WriteLine(Objekt3.calculatePrice(subtotal));