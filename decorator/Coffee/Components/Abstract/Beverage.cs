using System;

namespace decorator {

    public abstract class Beverage {
        public virtual string Description { get; protected set; } = "Unknown Beverage";
        
        //implement cost in the subclasses
        public abstract double Cost();
    }
}

