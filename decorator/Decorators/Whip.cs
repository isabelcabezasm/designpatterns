namespace decorator
{
    public class Whip : CondimentDecorator
    {
        Beverage _beverage;

        public Whip (Beverage beverage){
            this._beverage = beverage;
        }

        public override string Description => _beverage.Description + ", Whip";

        public override double Cost(){
            return .10 + _beverage.Cost();
        }
        
    }
}