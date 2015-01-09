using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirclePropertiesApp
{
    class Circle
    {
        public double GetDiameter(double radiusOfCircle)
        {
            return 2 * radiusOfCircle;
        }

        public double GetPerimeter(double radiusOfCircle)
        {
            return Math.PI*GetDiameter(radiusOfCircle);
        }

        public double GetArea(double radiusOfCircle)
        {
            return Math.PI * radiusOfCircle * radiusOfCircle;
        }

    }
}
