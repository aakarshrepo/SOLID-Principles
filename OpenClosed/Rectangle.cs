using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Principles.OpenClosed
{
    public class Rectangle :IArea
    {
        public double height { get; set; }
        public double width { get; set; }
        public double Area() => height * width;
    }
}
