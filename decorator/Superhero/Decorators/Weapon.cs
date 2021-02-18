namespace decorator
{
    public class Weapon : ComplementDecorator
    {
        Superhero _figure;

        public Weapon (Superhero figure){
            this._figure = figure;
        }

        public override string Description => _figure.Description + ", Soy";

        public override double Cost(){
            return 2 + _figure.Cost();
        }
        
    }
}