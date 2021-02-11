using System;

namespace decorator {
    public class Espresso : Beverage {

        public Espresso() {
            this.description = "Espresso";
        }

        public double cost() {
            return 1.99;
        }

    }
}

