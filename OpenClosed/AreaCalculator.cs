﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Principles.OpenClosed
{
    public class AreaCalculator
    {
        public double totalArea(IArea[] arrObjects)
        {
            double area = 0;
            foreach (var obj in arrObjects)
            {
                //if (obj is Rectangle)
                //{
                //    var objRectangle = (Rectangle)obj;
                //    area += objRectangle.Height * objRectangle.Width;
                //}
                //else
                //{
                //    var objCircle = (Circle)obj;
                //    area += objCircle.Radius * objCircle.Radius * Math.PI;
                //}
                area += obj.Area();
            }
            return area;
        }
    }
}
