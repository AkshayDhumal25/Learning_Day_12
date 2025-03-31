//Diamond Problem
using System;
namespace diamondProblem
{
    interface IA
    {
        public void Print()
        {
            Console.WriteLine("IA");
        }
    }
    interface IB : IA { }
    interface IC : IA { }
    class D : IB, IC
    {
        public void Print()
        {
            Console.WriteLine("Class D"); ;
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            D d = new D();
            d.Print();
        }
    }
}