using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureClassWork.Model
{
    internal class Chair:AbsMethod
    {

        public bool IsAdjustable { get; set; }

        public override double CalculateCost()
        {
            double cost = Price;
            if (IsAdjustable)
            {
                cost += 10;
            }
            return cost;
        }
    }
}
