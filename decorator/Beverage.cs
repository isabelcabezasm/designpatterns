using System;

namespace decorator {

    public abstract class Beverage {
        public String description =  String.Empty(); //?? 

        //get description is already implemented here
        public String getDescription() {
             return description;
        }

        //implement cost in the subclasses
        public abstract double cost();
    }
}

