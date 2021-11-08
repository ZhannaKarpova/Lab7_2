using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Int32.Parse(Console.ReadLine());
            double V, S;
            CalsСube(a, out V, out S);
            Console.WriteLine(V);
            Console.WriteLine(S);
            Console.ReadKey();
        }

        static void CalsСube(int a, out double V, out double S)
        {
            V = Math.Pow(a, 3);
            S = Math.Pow(a, 3)*6;
        }
       
    }
}
