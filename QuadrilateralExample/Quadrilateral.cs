using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace QuadrilateralExample
{
    //have ken go over with me
   public class Quadrilateral
    {
        public int side1 { get; set; }
        public int side2 { get; set; }
        public int side3 { get; set; }
        public int side4 { get; set; }

        public void Perimeter()
        {
            var Perimeter = side1 + side2 + side3 + side4;
            Console.WriteLine($"Perimeter is {Perimeter}");
           
        }

        public Quadrilateral(int s1, int s2, int s3, int s4)
        {
            side1 = s1;
            side2 = s2;
            side3 = s3;
            side4 = s4;
        }   

        public Quadrilateral()
        {

        }
       
    }
}
