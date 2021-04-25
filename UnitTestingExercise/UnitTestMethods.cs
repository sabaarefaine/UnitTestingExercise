using System;
using System.Collections.Generic;
using System.Linq;

namespace UnitTestingExercise
{
    public class UnitTestMethods
    {
        // Make sure your references are set properly
            //DONE Righ-click on Dependencies in your .Tests project and set your reference



        // Create an Add method that passes 3 integers

        public int Add (int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }

   

        // Create a Subtract method that passes 2 integers
            // Keep track of which number is getting passed as minuend and subtrahend
        public int Subtract (int minuend, int subtrahend)
        {
            return minuend - subtrahend;
        }

        // Create a Multiply method that passes 2 integers

        public int Multiply (int num1, int num2)
        {
            return num1 * num2;
        }

        // Create a Divide method that passes 2 integers

        public double Divide (int num1, int num2)
        {
            return num1 / num2;
        }


        // Create 2 methods that will utilize the [Fact] tests you wrote

        public string GetHello()
        {
            return "Hello";
        }

        public int[] EvensBelow100()
        {
            int[] myArray = new int[] {2, 4, 6, 8, 10, 12, 14, 16, 18, 20, 22, 24, 26, 28, 30, 32, 34, 36, 38, 40, 42, 44, 46, 48, 50,
                52, 54, 56, 58, 60, 62, 64, 66, 68 ,70, 72, 74, 76, 78, 80, 82, 84, 86, 88, 90, 92, 94, 96, 98};

            return myArray;
        }
        
    }
}
