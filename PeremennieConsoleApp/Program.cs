using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace PeremennieConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Молли";
            string lastName = "Лисова";
            string age = "20";
            string email = "12345@mail.ru";
            string scoreProgramming = "60";
            string scoreMath = "76";
            string scorePhysics = "57";

            string pattern = "Имя: {0} \nФамилия: {1} \nВозраст: {2} \nПочта: {3} \nБаллы по программированию: {4} \nБаллы по математике: {5} \nБаллы по Физике: {6}";

            Console.WriteLine(pattern,
                              firstName,
                              lastName,
                              age,
                              email,
                              scoreProgramming,
                              scoreMath,
                              scorePhysics);
            Console.ReadLine();
        }
    }
}
