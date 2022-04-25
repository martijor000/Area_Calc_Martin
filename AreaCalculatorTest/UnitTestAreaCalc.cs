using Microsoft.VisualStudio.TestTools.UnitTesting;
using Martin_Area_Calculator;

namespace AreaCalculatorTest
{
    [TestClass]
    public class UnitTestAreaCalc
    {

        private AreaCalculator ac = new AreaCalculator();

        [TestMethod]
        public void TestingWrongStringMethodInput()
        {
            //Testing False Input to the private method
            ac.getSquareArea("1", "2");
        }

        [TestMethod]
        public void TestingCorrectStringMethodInput()
        {
            //Testing Correct Input to the private method
            ac.getSquareArea("one", "two");
            ac.getSquareArea("three", "four");
            ac.getSquareArea("five", "six");
            ac.getSquareArea("seven", "eight");
            ac.getSquareArea("nine", "ten");

        }
        
        [TestMethod]
        public void TestingGetCircleDiameter()
        {
            ac.getCircleDiameter(20);
            ac.getCircleDiameter(0);
        }

        [TestMethod]
        public void TestingGetCircleRadius()
        {
            ac.getCircleRadius(20);
            ac.getCircleRadius(0);
        }

        [TestMethod]
        public void TestingGetSquareWithNum()
        {
            ac.getSquareArea(20, 10);
        }

        [TestMethod]
        public void TestingGetRectangle()
        {
            ac.getRectangleArea(20, 10);
        }

        [TestMethod]
        public void TestingGetParallelogram()
        {
            ac.getParallelogramArea(20, 10);
        }

        [TestMethod]
        public void TestingGetTriangle()
        {
            ac.getTriangleArea(20, 10);
        }
    }
}