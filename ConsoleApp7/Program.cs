using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            ValueTypes();

            for (;;)
            {
                greeting();

                age();
                ustawienia();
            }
        }

        private static void ValueTypes()
        {
            int MaxInt = int.MaxValue;
            int MinInt = int.MinValue;

            long maxLong = long.MaxValue;
            long minLong = long.MinValue;

            Console.WriteLine("MaxInt = " + MaxInt);
            Console.WriteLine("MinInt = " + MinInt);
            Console.WriteLine("maxLong = " + maxLong);
            Console.WriteLine("minLong = " +minLong);
        }

        /// <summary>
        /// Ustawienia
        /// </summary>
        private static void ustawienia()
        {
            Console.ReadKey();
            Console.Clear();
            Console.ResetColor();
        }
        /// <summary>
        /// Wypisuje komunikat zależny od wieku
        /// </summary>
        private static void age()
        {
            Console.Write("Wpisz ile masz lat: ");

            int age;
            bool result = int.TryParse(Console.ReadLine(), out age);

            if (age > 18)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Jesteś pełnoletni");
            }
            else if (result == false)
            {
                Console.WriteLine("Wprowadziłeś niepoprawny wiek!");
            }
            else
            {
                Console.WriteLine("Jesteś niepełnoletni!");
            }
        }
        /// <summary>
        /// Wypisuję powitanie użytkownika
        /// </summary>

        private static void greeting()
        {
            Console.Write("Podaj swoje imię: ");
            string name = Console.ReadLine();

            Console.WriteLine("Witaj, " + name);
        }
    }
}
