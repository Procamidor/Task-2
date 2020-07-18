using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {   //Exercise 2
            double chisloPi = 3.141592653;
            decimal chisloEylera = 2.7182818284590452m;
            Console.Write("PI =  ");
            Console.WriteLine(chisloPi);
            Console.Write("E = ");
            Console.WriteLine(chisloEylera);
            //Exercise 3
            string n = "\nмоя строка 1";
            string t = "\tмоя строка 2";
            string a = "\aмоя строка 3";
            Console.WriteLine(n);
            Console.WriteLine(t);
            Console.WriteLine(a);
            Console.ReadKey();
        }
    }
}
