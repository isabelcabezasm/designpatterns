using System;

namespace strategy
{        
    public abstract class Duck {
        protected IFlyable flyBehavior;
        protected IQuackable quackBehavior;

        public Duck() {}

        public void performFly(){
            flyBehavior.fly();
        }
        
        public void performQuack() {
            quackBehavior.quack();
        } 

        public void swim() {
            Console.Write("All ducks float, even decoys!");
        }
    }
}
