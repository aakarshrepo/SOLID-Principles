using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Principles.OpenClosed
{
    public class Circle : IArea
    {
        public double radius { get; set; }
        public double Area() => Math.PI * radius * radius;
        
    }
}
