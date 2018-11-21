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

        public double calcHypOfRightTri(int side1, int side2)
        {
            return 0;
        }

        public double calcAreaOfRightTri(int side1, int side2)
        {
            return 0;
        }

        public int calcAngleOfTri(int angle1, int angle2)
        {
            if (angle1 <= 0 || angle2 <= 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            int finalAngle = TRIANGLE_ANGLE_SUM - angle1 - angle2;
            return finalAngle;
        }
    }
}
