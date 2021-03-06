using System;

namespace SuperheroStrategy
{        
    public abstract class Superhero {
        protected IFlyable flyBehavior;
        protected IAttackable attackBehavior;

        public String realName;
        public String alias;
        public String universe;

        public Superhero() {}

        public void performFly(){
            flyBehavior.Fly();
        }
        
        public void performAttack() {
            attackBehavior.Attack();
        } 

        public void Introduction(){
            Console.WriteLine("Hi! My name is " + realName + ", but I'm more known as " + alias );
        }
    }
}
