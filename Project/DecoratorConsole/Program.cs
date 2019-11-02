using DecoratorConsole.ConcreteComponent;
using System;

namespace DecoratorConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            HondaCity car = new HondaCity();

            Console.WriteLine($"Honda City preço : {car.Price}");

            SpecialOffer offer = new SpecialOffer(car);
            offer.DiscountPercentage = 25;
            offer.Offer = "25 % de desconto";

            Console.WriteLine($"{offer.Price} @ Honda preço especial : {offer.Offer} ");

            Console.ReadKey();

        }
    }
}
