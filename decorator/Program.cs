using System;

namespace decorator
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Beverage without condiments
            Beverage beverage = new Espresso();
            Console.WriteLine(beverage.Description + ": " + beverage.Cost() +"€");

            Beverage beverage2 = new DarkRoast();
            beverage2 = new Mocha(beverage2); //wrap it with a mocha
            beverage2 = new Mocha(beverage2); //wrap it with a second mocha
            beverage2 = new Whip(beverage2); //wrap it with a Whip
            Console.WriteLine(beverage2.Description + ": " + beverage2.Cost() +"€");

        }
    }
}
