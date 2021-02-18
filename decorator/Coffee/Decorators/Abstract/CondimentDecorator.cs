using System;

namespace decorator {

    public abstract class CondimentDecorator : Beverage {
        //the contiment classes all reimplement the "getDescription" method.
        public abstract override string Description {get;}
    }
}

