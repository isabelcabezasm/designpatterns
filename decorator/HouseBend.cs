using System;

namespace decorator {
    public class HouseBlend : Beverage {

        public HouseBlend() {
            this.description = "House Blend coffee";
        }

        public double cost() {
            return 0.89;
        }

    }
}