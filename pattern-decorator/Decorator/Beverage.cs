using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern_decorator.Decorator
{
    public abstract class Beverage
    {
        public virtual string Description { get; set; }

        public abstract double Cost { get; }

        public abstract string Prepare();
    }
}
