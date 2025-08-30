using System;

namespace DelegatesDemo
{
    delegate double MyOperation(double a, double b);

    class Program
    {
        static double Calculate(double x, double y, MyOperation op)
        {
            return op(x, y);
        }

        static void Main()
        {
            MyOperation add = (a, b) => a + b;
            MyOperation sub = (a, b) => a - b;
            MyOperation mul = (a, b) => a * b;
            MyOperation div = (a, b) => a / b;

            Console.WriteLine("Add: " + Calculate(10, 5, add));
            Console.WriteLine("Subtract: " + Calculate(10, 5, sub));
            Console.WriteLine("Multiply: " + Calculate(10, 5, mul));
            Console.WriteLine("Divide: " + Calculate(10, 5, div));
        }
    }
}