namespace Superheroes
{
    public class SuperheroesControl
    {
        ICommand movement; 

        public void SetCommand (ICommand command)
        {
            movement = command; 
        }

        public void ButtonWasPressed()
        {
            movement.Execute();
        }

    }

}   