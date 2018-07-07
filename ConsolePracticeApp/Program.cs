using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePracticeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Basic Console I/O *****");
            DefaultDeclarations();
            NewingDataTypes();
            DataTypeFunctionality();
            Console.ReadLine();
        }

        private static void DataTypeFunctionality()
        {
            Console.WriteLine("=> Data type Functionality:");
            Console.WriteLine("Max of int: {0}", int.MaxValue);
            Console.WriteLine("Min of int: {0}", int.MinValue);
            Console.WriteLine("Max of double: {0}", double.MaxValue);
            Console.WriteLine("Min of double: {0}", double.MinValue);
            Console.WriteLine("double.Epsilon: {0}", double.Epsilon);
            Console.WriteLine("double.PositiveInfinity: {0}",
                double.PositiveInfinity);
            Console.WriteLine("double.NegativeInfinity: {0}",
                double.NegativeInfinity);
            Console.WriteLine();
        }

        private static void NewingDataTypes()
        {
            Console.WriteLine("=> Using to create new variables");
            bool b = new bool();
            int i = new int();
            double d = new double();
            DateTime dt = new DateTime();
            Console.WriteLine("{0},{1},{2},{3}",b,i,d,dt);
            Console.WriteLine();
        }

        private static void DefaultDeclarations()
        {
           Console.WriteLine("=> Default Declarations");
            int i = default;
        }
    }
}
