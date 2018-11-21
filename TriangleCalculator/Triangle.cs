using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleCalculator
{
    public class Triangle
    {
        //Sum of triangle's angles
        private const int TRIANGLE_ANGLE_SUM = 180;

        public double calcHypOfRightTri(double side1, double side2)
        {
            if (side1 <= 0 || side2 <= 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            double hyp = Math.Sqrt((side1 * side1) + (side2 * side2));
            return hyp;
        }

        public double calcAreaOfRightTri(double side1, double side2)
        {
            if (side1 <= 0 || side2 <= 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            double area = (side1 * side2) / 2;
            return area;
        }

        public int calcAngleOfTri(int angle1, int angle2)
        {
            if (angle1 <= 0 || angle2 <= 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            else if (angle1 + angle2 >= TRIANGLE_ANGLE_SUM)
            {
                throw new ArgumentException();
            }
            int finalAngle = TRIANGLE_ANGLE_SUM - angle1 - angle2;
            return finalAngle;
        }
    }
}
