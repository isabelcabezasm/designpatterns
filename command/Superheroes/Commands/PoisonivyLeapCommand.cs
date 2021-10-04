namespace Superheroes
{
    public class PoisonivyLeapCommand: ICommand 
    {       
        Poisonivy poisonivy; 

        public PoisonivyLeapCommand (Poisonivy poisonivy)
        {
            this.poisonivy = poisonivy; 
        }

        public void Execute()
        {
            poisonivy.UseLeaping();
        }
        
    }
}