using System;

namespace decorator
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Beverage without condiments
            Beverage beverage = new Espresso();
            Console.WriteLine(beverage.getDescription() + ": " + beverage.cost() +"€");

            Beverage beverage2 = new DarkRoast();
            beverage2 = new Mocha(beverage2); //wrap it with a mocha
            beverage2 = new Mocha(beverage2); //wrap it with a second mocha
            beverage2 = new Whip(beverage2); //wrap it with a Whip
            Console.WriteLine(beverage2.getDescription() + ": " + beverage2.cost() +"€");

        }
    }
}
