using System;

namespace strategy
{        
    public abstract class Duck {
        protected IFlyBehavior flyBehavior;
        protected IQuackBehavior quackBehavior;

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
