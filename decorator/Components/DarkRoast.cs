using System;

namespace decorator {
    public class DarkRoast : Beverage {

        public DarkRoast() {
            this.Description = "Dark Roast";
        }

        public override double Cost() {
            return 0.99;
        }

    }
}
