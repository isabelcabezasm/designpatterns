using System;

namespace decorator {
    public class Decaf : Beverage {

        public Decaf() {
            this.description = "Decaf Roast";
        }

        public double cost() {
            return 1.05;
        }

    }
}
