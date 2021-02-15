using System;

namespace decorator {
    public class Decaf : Beverage {

        public Decaf() {
            this.Description = "Decaf Roast";
        }

        public override double Cost() {
            return 1.05;
        }

    }
}
