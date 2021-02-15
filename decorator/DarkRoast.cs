using System;

namespace decorator {
    public class DarkRoast : Beverage {

        public DarkRoast() {
            this.description = "Dark Roast";
        }

        public override double cost() {
            return 0.99;
        }

    }
}
