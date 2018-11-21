using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleCalculator;

namespace TriangleCalculatorTests
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void Should_Calculate_Angle_From_Two_Valid_Sides()
        {
            //Arrange
            Triangle tri = new Triangle();

            int angle1 = 60;
            int angle2 = 60;
            int finalAngle = 60;

            int testAngle = 0;

            //Act
            testAngle = tri.calcAngleOfTri(angle1, angle2);

            //Assert
            Assert.AreEqual(finalAngle, testAngle);
        }

    }
}
