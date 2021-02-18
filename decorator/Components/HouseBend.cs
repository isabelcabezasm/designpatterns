using System;

namespace decorator {
    public class HouseBlend : Beverage {

        public HouseBlend() {
            this.Description = "House Blend coffee";
        }

        public override double Cost() {
            return 0.89;
        }

    }
}