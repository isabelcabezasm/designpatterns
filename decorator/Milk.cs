namespace decorator
{
    public class Milk : CondimentDecorator
    {
        Beverage beverage;

        public Milk (Beverage beverage){
            this.beverage = beverage;
        }

        public override string getDescription(){
            return beverage.getDescription() + ", Milk";
        }

        public override double cost(){
            return .10 + beverage.cost();
        }
        
    }
}