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
            int scoreProgramming = 60;
            int scoreMath = 76;
            int scorePhysics = 57;
            int summ = (scoreProgramming + scoreMath + scorePhysics);
            int arithmeticMean = summ / 3;

            Console.WriteLine(summ);
            Console.WriteLine(arithmeticMean);
            
            Console.ReadKey();
        }
    }
}
