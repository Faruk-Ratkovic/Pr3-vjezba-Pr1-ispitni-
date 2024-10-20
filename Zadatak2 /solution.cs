using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static bool provjeriUvjet(int a, int b, int c)
        {

            return a - b == 5 && b - c == 5 || c - b == 5 && b - a == 5;
        }
        public static int generateRandomNumber()
        {
            Random rnd = new Random();
            return rnd.Next(1, 14);
        }
        public static void Main()
        {
            int a, b, c;
            int counter=0;
            do
            {
                counter++;
                a = generateRandomNumber();
                b= generateRandomNumber();
                c = generateRandomNumber();
            }
            while (!provjeriUvjet(a,b,c));
            Console.WriteLine($"Ukupno pokusaja: {counter}");
            Console.WriteLine($"Krajnja kombinacija: {a} {b} {c}");
         



        }
    }
}
