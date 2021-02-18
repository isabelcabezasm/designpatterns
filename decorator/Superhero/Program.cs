using System;

namespace decorator
{
    public class Program
    {
        static void Main(string[] args)
        {
            Superhero figure = new Superwoman();
            Console.WriteLine(figure.Description + ": " + figure.Cost() +"€");

            Superhero figure2 = new Wonderwoman();
            figure2 = new Shield(figure2); //wrap it with a  Shield
            figure2 = new Sword(figure2); //wrap it with Sword
            figure2 = new Sword(figure2); //wrap it with a another Sword
            Console.WriteLine(figure2.Description + ": " + figure2.Cost() +"€");

        }
    }
}

