namespace Superheroes
{

    public class BatmanApplyHoldCommand: ICommand 
    {       
        Batman batman; 

        public BatmanApplyHoldCommand (Batman batman)
        {
            this.batman = batman; 
        }

        public void Execute()
        {
            batman.UseMartialArts();
        }
        
    }

}   