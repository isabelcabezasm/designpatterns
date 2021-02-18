using System;

namespace decorator {

    public class Batwoman : Superhero {

        public Batwoman() {
            this.Description = "Batwoman";
        }

        public override double Cost() {
            return 18.05;
        }

    }
}
