namespace decorator
{
    public class Mask : ComplementDecorator
    {
        Superhero _figure;

        public Mask (Superhero figure){
            _figure = figure;
        }

        public override string Description => _figure.Description + ", with mask";

        public override double Cost(){
            return 2.10 + _figure.Cost();
        }
        
    }
}