using System;
using NUnit.Framework;

namespace Open_Lab_01._04
{
    public class Triangle
    {
        public double Area(double foundation, double height)
        {
            double ret = 0.00;
            ret = foundation * height / 2;
            return ret;
        }
    }
}