using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace Order.Management
{
    public abstract class Shape
    {
        // Do any of these actually need to be public?
        // Shouldn't they be either protected or private?
        public string Name { get; protected set; }
        public int Price { get; protected set;  }
        public int RedShapes { get; protected set; }
        public int BlueShapes { get; protected set; }
        public int YellowShapes { get; protected set; }
        public int TotalQuantityOfShape()
        {
            return RedShapes + BlueShapes + YellowShapes;
        }

        public int AdditionalChargeTotal()
        {
            return RedShapes * Globals.ExtraChargeForRed;
        }

        public virtual int Total()
        {
            return TotalQuantityOfShape() * Price;
        }

    }
}
