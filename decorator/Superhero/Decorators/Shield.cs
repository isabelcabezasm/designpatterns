namespace decorator
{
    public class Shield : ComplementDecorator
    {
        Superhero _figure;

        public Shield (Superhero figure){
            this._figure = figure;
        }

        public override string Description => _figure.Description + ", with shield";

        public override double Cost(){
            return 1.20 + _figure.Cost();
        }
        
    }
}