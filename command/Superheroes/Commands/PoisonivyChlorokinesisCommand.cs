namespace Superheroes
{
    public class PoisonivyChlorokinesisCommand: ICommand 
    {       
        Poisonivy poisonivy; 

        public PoisonivyChlorokinesisCommand (Poisonivy poisonivy)
        {
            this.poisonivy = poisonivy; 
        }

        public void Execute()
        {
            poisonivy.UseChlorokinesis();
        }
        
    }
}
    
