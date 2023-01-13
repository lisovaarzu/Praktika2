using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolVoBallovConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            float scoreProgramming = 65.5F;
            float scoreMath = 76.5F;
            float scorePhysics = 57.5F;
            float summ = (scoreProgramming + scoreMath + scorePhysics);
            float arithmeticMean = summ / 3;

            Console.WriteLine(summ);
            Console.WriteLine(arithmeticMean);
            
            Console.ReadKey();
        }
    }
}
