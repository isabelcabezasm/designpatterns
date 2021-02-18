using System;

namespace decorator {
    public class Espresso : Beverage {

        public Espresso() {
            this.Description = "Espresso";
        }

        public override double Cost() {
            return 1.99;
        }

    }
}

