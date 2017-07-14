using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    public class Calculator
    {
        public int Add(int int1, int int2)
        {
            return int1 + int2;
        }

        public int Subtract(int int1, int int2)
        {
            return int1 - int2;
        }

        public int Multiply(int int1, int int2)
        {
            return int1 * int2;
        }

        public int Divide(int int1, int int2)
        {
            return int1 / int2;
        }
    };

}