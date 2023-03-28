/*hruska*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_28._03._23
{
    class Program
    {
        static void Main(string[] args)
        {
            int hrusky = 0;
            int jablka = 0;
            string a;
            string b;
            int auto = 0;
            int vaha=1;
            int auta = 0;

            while (vaha != 0)
            {
                Console.WriteLine("Zadej auto, do ktereho chces nakladat, 1 jsou jablka a 2 jsou hrusky:");
                a = Console.ReadLine();

                while (!int.TryParse(a, out auto)|| (auto > 2 || auto < 1))
                {
                    Console.WriteLine("Zadal jsi spatnou hodnotu, 1 jsou jablka a 2 jsou hrusky, zadej znovu");
                    a = Console.ReadLine();
                }

                if (auto == 1)
                {   Console.WriteLine("Zadej počet kg jablek: ");
                    b = Console.ReadLine();
                    while (!int.TryParse(b, out vaha))
                    {
                        Console.WriteLine("Zadal jsi spatnou hodnotu, zadej znovu");
                        b = Console.ReadLine();
                    }
                    jablka = jablka + vaha;
                }

                if(auto == 2)
                {
                    Console.WriteLine("Zadej počet kg hrusek: ");
                    b = Console.ReadLine();
                    while (!int.TryParse(b, out vaha))
                    {
                        Console.WriteLine("Zadal jsi spatnou hodnotu, zadej znovu");
                        b = Console.ReadLine();
                    }
                    hrusky = hrusky + vaha;
                }
                auta = auta + 1;
                Console.WriteLine("Celkova vaha danych kusu je: ");
                Console.WriteLine("Jablka   " + jablka + " kg ");
                Console.WriteLine("Hrusky   " + hrusky + " kg ");
                Console.WriteLine("Celkem   " + (jablka + hrusky) + " kg ");
                Console.WriteLine("Celkem jedno auto poveze " + ((hrusky + jablka) / auta) + "kg a pojede celkem " + auta + " aut");
            }
            Console.WriteLine("Celkova vaha danych kusu je: ");
            Console.WriteLine("Jablka   " + jablka + " kg ");
            Console.WriteLine("Hrusky   " + hrusky + " kg ");
            Console.WriteLine("Celkem   " + (jablka+hrusky) + " kg ");
            Console.WriteLine("Celkem jedno auto poveze " + ((hrusky + jablka) / auta) + "kg a pojede celkem " + auta + " aut");
            Console.WriteLine(" ");
        }
    }
}
