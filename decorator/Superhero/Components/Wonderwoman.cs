using System;

namespace decorator {
    public class Wonderwoman : Superhero {

        public Wonderwoman() {
            this.Description = "Wonderwoman";
        }

        public override double Cost() {
            return 25;
        }

    }
}