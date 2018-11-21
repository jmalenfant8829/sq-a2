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

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Should_Throw_Exception_When_Angle_Is_Negative()
        {
            //Arrange
            Triangle tri = new Triangle();

            int angle1 = -30;
            int angle2 = -30;

            int testAngle = 0;

            //Act
            testAngle = tri.calcAngleOfTri(angle1, angle2);

            //Assert already handled
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Should_Throw_Exception_When_Sum_Of_Angles_Over_180()
        {
            //Arrange
            Triangle tri = new Triangle();

            int angle1 = 100;
            int angle2 = 100;

            int testAngle = 0;

            //Act
            testAngle = tri.calcAngleOfTri(angle1, angle2);

            //Assert already handled
        }

        [TestMethod]
        public void Should_Calc_Area_Of_Tri_Given_Two_Valid_Sides()
        {
            //Arrange
            Triangle tri = new Triangle();

            double side1 = 4;
            double side2 = 6;
            double area = 12;

            double funcArea = 0;

            //Act
            funcArea = tri.calcAreaOfRightTri(side1, side2);

            //Assert
            Assert.AreEqual(area, funcArea);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Should_Throw_Exception_When_Area_Calc_Side_Is_Negative()
        {
            Triangle tri = new Triangle();

            double side1 = -2;
            double side2 = -2;

            double funcArea = 0;

            //Act
            funcArea = tri.calcAreaOfRightTri(side1, side2);

            //Assert already handled
        }

        [TestMethod]
        public void Should_Calc_Hypotenuse_Of_Tri_Given_Two_Valid_Sides()
        {
            //Arrange
            Triangle tri = new Triangle();

            double side1 = 3;
            double side2 = 4;
            double hyp = 5;

            double funcHyp = 0;

            //Act
            funcHyp = tri.calcHypOfRightTri(side1, side2);

            //Assert
            Assert.AreEqual(hyp, funcHyp);
        }
    }
}
