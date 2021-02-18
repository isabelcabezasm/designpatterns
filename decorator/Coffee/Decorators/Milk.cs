namespace decorator
{
    public class Milk : CondimentDecorator
    {
        Beverage _beverage;

        public Milk (Beverage beverage){
            _beverage = beverage;
        }

        public override string Description => _beverage.Description + ", Milk";

        public override double Cost(){
            return .10 + _beverage.Cost();
        }
        
    }
}