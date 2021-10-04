namespace Superheroes
{

    public class CatwomanRunCommand: ICommand 
    {       
        Catwoman catwoman; 

        public CatwomanRunCommand (Catwoman catwoman)
        {
            this.catwoman = catwoman; 
        }

        public void Execute()
        {
            catwoman.UseSpeed();
        }
        
    }

}   