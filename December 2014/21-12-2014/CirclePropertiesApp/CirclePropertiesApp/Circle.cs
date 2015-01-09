using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirclePropertiesApp
{
    class Circle
    {
        
        private double area;
        private double diameter;
        private double perimeter;

        public Circle()
        {
        }
        public double GetDiameter(double radiusOfCircle)
        {
            diameter = 2 * radiusOfCircle;
            return diameter;
        }

        public double GetPerimeter(double radiusOfCircle)
        {
            perimeter = 2 * Math.PI * radiusOfCircle;
            return perimeter;
        }

        public double GetArea(double radiusOfCircle)
        {
            area = Math.PI * radiusOfCircle * radiusOfCircle;
            return area;
        }

    }
}
