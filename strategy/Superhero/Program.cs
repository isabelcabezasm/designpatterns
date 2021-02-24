using System;

namespace SuperheroStrategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Superhero heroine1 = new Wonderwoman();
            
            heroine1.Introduction();
            heroine1.performAttack();
            heroine1.performFly();
        }
    }

}