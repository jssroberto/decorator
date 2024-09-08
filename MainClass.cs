using Beverages;
using System;
using Condiments;

namespace StarbuzzCoffee
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            // Creamos un HouseBlend de ejemplo
            Beverage houseBlend = new HouseBlend();
            Console.WriteLine($"{houseBlend.GetDescription()} - ${houseBlend.GetCost()}");

            // Le agregamos leche
            houseBlend = new Milk(houseBlend);
            Console.WriteLine($"{houseBlend.GetDescription()} - ${houseBlend.GetCost()}");

            // Le agregamos soja
            houseBlend = new Soy(houseBlend);
            Console.WriteLine($"{houseBlend.GetDescription()} - ${houseBlend.GetCost()}");

            // Le agregamos chocolate
            houseBlend = new Chocolate(houseBlend);
            Console.WriteLine($"{houseBlend.GetDescription()} - ${houseBlend.GetCost()}");

            // Le agregamos crema batida
            houseBlend = new WhippedCream(houseBlend);
            Console.WriteLine($"{houseBlend.GetDescription()} - ${houseBlend.GetCost()}");

            // Ahora un espresso con soja y crema batida
            Beverage espresso = new Espresso();
            espresso = new Soy(espresso);
            espresso = new WhippedCream(espresso);

            Console.WriteLine($"{espresso.GetDescription()} - ${espresso.GetCost()}");
       
        }
    }
}