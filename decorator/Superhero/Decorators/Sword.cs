namespace decorator
{
    public class Sword : ComplementDecorator
    {
        Superhero _figure;

        public Sword (Superhero figure){
            this._figure = figure;
        }

        public override string Description => _figure.Description + ", with sword";

        public override double Cost(){
            return 1.10 + _figure.Cost();
        }
        
    }
}