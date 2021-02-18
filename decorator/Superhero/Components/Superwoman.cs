using System;

namespace decorator {
    public class Superwoman : Superhero {

        public Superwoman() {
            this.Description = "Superwoman";
        }

        public override double Cost() {
            return 23.4;
        }

    }
}
