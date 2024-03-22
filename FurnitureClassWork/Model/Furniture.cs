using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureClassWork.Model
{
    internal class Furniture:AbsMethod
    {
        public int Numberofshelves { get; set; }

        public override double CalculateCost()
        {
            return Price * Numberofshelves;
        }
    }
}
