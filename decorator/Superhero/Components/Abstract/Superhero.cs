using System;

namespace decorator {

    public abstract class Superhero {
        public virtual string Description { get; protected set; } = "Unknown Superhero";
        
        //implement cost in the subclasses
        public abstract double Cost();
    }
}

