using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureClassWork.Model
{
    abstract class AbsMethod
    {
        public string Name { get; set; }
        public string Material { get; set; }
        public double Price { get; set; }

        public abstract double CalculateCost();
    }
}
