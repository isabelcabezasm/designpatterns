using System;

namespace Superheroes
{
    class Game
    {
        static void Main(string[] args)
        {

            SuperheroesControl newRound = new SuperheroesControl();

            //Declare character 1 and its movements
            Batman batman = new  Batman();

            BatmanApplyHoldCommand karateHold= new BatmanApplyHoldCommand(batman);
            BatmanUseSwordCommand sword = new BatmanUseSwordCommand(batman);

            //Declare character 2 and its movements
            Poisonivy poisonivi = new Poisonivy();

            PoisonivyChlorokinesisCommand chlorokinesis = new PoisonivyChlorokinesisCommand(poisonivi);
            PoisonivyLeapCommand leap = new PoisonivyLeapCommand(poisonivi);



            //lets play!!
            newRound.SetCommand(karateHold);
            newRound.ButtonWasPressed();  

            newRound.SetCommand(chlorokinesis);
            newRound.ButtonWasPressed();

            newRound.SetCommand(sword);
            newRound.ButtonWasPressed();  

            newRound.SetCommand(leap);
            newRound.ButtonWasPressed();  


        }
    }
}
