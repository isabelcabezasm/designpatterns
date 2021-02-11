using System;

namespace decorator {
    public class DarkRoast : Beverage {

        public DarkRoast() {
            this.description = "Dark Roast";
        }

        public double cost() {
            return 0.99;
        }

    }
}
