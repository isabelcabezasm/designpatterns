using System;

namespace SuperheroStrategy
{   
    public class Wonderwoman : Superhero {
        public Wonderwoman() {
            alias ="Wonder Woman";
            realName ="Princess Diana of Themyscira";
            
            attackBehavior = new Strength();
            flyBehavior = new Technology();
        }
    }
}