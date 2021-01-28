namespace strategy
{   
    public class MallardDuck : Duck {
        public MallardDuck() {
            quackBehavior = new Quack();
            flyBehavior = new FlyWithWings();
        }
    }
}