namespace Superheroes
{

    public class BatmanUseSwordCommand: ICommand 
    {       
        Batman batman; 

        public BatmanUseSwordCommand (Batman batman)
        {
            this.batman = batman; 
        }

        public void Execute()
        {
            batman.UseWeapon();
        }
        
    }

}   