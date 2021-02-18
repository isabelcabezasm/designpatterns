using System;

namespace decorator {
    public class CaptainMarvel : Superhero {

        public CaptainMarvel() {
            this.Description = "Espresso";
        }

        public override double Cost() {
            return 21.99;
        }

    }
}

