using System;
using System.Collections.Generic;
using System.Text;

namespace QuadrilateralExample
{
    public class Rectangle : Quadrilateral
    {
        
        public void Area()
        {
            var area = side1 * side2;
            Console.WriteLine($"Area of rectangle is {area}.");
        }
        public Rectangle(int s1, int s2) : base(s1, s2, s1, s2) { }
    }
}
