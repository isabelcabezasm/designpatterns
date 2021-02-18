namespace decorator
{
    public class Soy : CondimentDecorator
    {
        Beverage _beverage;

        public Soy (Beverage beverage){
            this._beverage = beverage;
        }

        public override string Description => _beverage.Description + ", Soy";

        public override double Cost(){
            return .15 + _beverage.Cost();
        }
        
    }
}