namespace decorator
{
    public class Mocha : CondimentDecorator
    {
        Beverage _beverage;

        public Mocha (Beverage beverage){
            this._beverage = beverage;
        }

        public override string Description => _beverage.Description + ", Mocha";

        public override double Cost(){
            return .20 + _beverage.Cost();
        }
        
    }
}