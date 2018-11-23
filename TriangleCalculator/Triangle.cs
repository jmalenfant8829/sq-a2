/*
FILE:          Triangle.cs
PROJECT:       INFO2180 Assignment 2
PROGRAMMER:    Julien Malenfant
FIRST VERSION: 20/11/2018
DESCRIPTION:   Definition for a triangle class that can calculate triangle formulas
*/

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

        /// <summary>
        /// Calculates the hypotenuse of a right triangle given two side lengths
        /// </summary>
        /// <param name="side1">First side</param>
        /// <param name="side2">Second side</param>
        /// <returns></returns>
        public double calcHypOfRightTri(double side1, double side2)
        {
            //Check if given 0 or negative values
            if (side1 <= 0 || side2 <= 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            //Calculate hypotenuse
            double hyp = Math.Sqrt((side1 * side1) + (side2 * side2));
            return hyp;
        }

        /// <summary>
        /// Calculates area of a right triangle given two side lengths
        /// </summary>
        /// <param name="side1">First side</param>
        /// <param name="side2">Second side</param>
        /// <returns></returns>
        public double calcAreaOfRightTri(double side1, double side2)
        {
            //Check if given 0 or negative values
            if (side1 <= 0 || side2 <= 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            //Calculate area
            double area = (side1 * side2) / 2;
            return area;
        }

        /// <summary>
        /// Calculates the third angle of a triangle given two other angles
        /// </summary>
        /// <param name="angle1"></param>
        /// <param name="angle2"></param>
        /// <returns></returns>
        public int calcAngleOfTri(int angle1, int angle2)
        {
            //Check if other angles are 0 or negative
            if (angle1 <= 0 || angle2 <= 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            //Check if given valeus are over 180 degrees already
            else if (angle1 + angle2 >= TRIANGLE_ANGLE_SUM)
            {
                throw new ArgumentException();
            }
            //Calculate angle
            int finalAngle = TRIANGLE_ANGLE_SUM - angle1 - angle2;
            return finalAngle;
        }
    }
}
