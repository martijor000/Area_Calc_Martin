using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Martin_Area_Calculator
{
    public class AreaCalculator
    {
        private int multiplying_by_two = 2;
        private double multiplying_by_half = 0.5;
        private double pi = 3.14;
        private int multiplying_by_100 = 100;

        public double getSquareArea(string width, string height) {

            int convertedWidth = stringConverter(width);
            int convertedHeight= stringConverter(height);
            return RoundNumber((double)convertedWidth * convertedHeight);
        }
        public double getSquareArea(int width, int height )       
        {
            return RoundNumber((double)width * height);
        }
        public double getRectangleArea(int width, int height)
        {
            return RoundNumber((double)width * height);
        }
        public double getTriangleArea(int baseValue, int height)
        {
            return RoundNumber((double)(multiplying_by_half * baseValue * height));
        }
        public double getParallelogramArea(int baseValue, int height)
        {
            return RoundNumber((double)baseValue * height);
        }
        public double getCircleRadius(int circumference)
        {
            return RoundNumber((double)(circumference / multiplying_by_two * pi));  
        }
        public double getCircleDiameter(int circumference)
        {
            return RoundNumber((double)(circumference / multiplying_by_two * pi) * multiplying_by_two);
        }
        private double RoundNumber(double roundMe)
        {
            return Math.Round(roundMe * multiplying_by_100) / multiplying_by_100;
        }
        private int stringConverter(string number)
        {

            if (number == "one")
            {
                return 1;
            }
            else if (number =="two")
            {
                return 2;
            }
            else if (number == "three")
            {
                return 3;
            }
            else if (number == "four")
            {
                return 4;
            }
            else if (number == "five")
            {
                return 5;
            }
            else if (number == "six")
            {
                return 6;
            }
            else if (number == "seven")
            {
                return 7;
            }
            else if(number == "eight")
            {
                return 8;
            }
            else if(number == "nine")
            {
                return 9;
            }
            else if (number == "ten")
            {
                return 10;
            }
            else
            {
                return -1;
            }
        }
    }
}
