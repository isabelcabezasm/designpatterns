using System;

namespace decorator {
    public class Espresso : Beverage {

        public Espresso() {
            this.description = "Espresso";
        }

        public override double cost() {
            return 1.99;
        }

    }
}

