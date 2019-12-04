using System;

namespace Hello

{
    class Program
    {
        
        static void Main(string[] args)
        {
            ValuesTypes();

            for (; ; )
            {
                Greeting();
                Age();
                Settings();
            }

        }

        private static void ValuesTypes()
        {
            int minint = int.MinValue;
            int maxint = int.MaxValue;
            long minlong = long.MinValue;
            long maxlong = long.MaxValue;

            Console.WriteLine("minint: " + minint);
            Console.WriteLine("maxint: " + maxint);
            Console.WriteLine("minlong: " + minlong);
            Console.WriteLine("maxlong: " + maxlong);
        }

        /// <summary>
        /// Metoda resetuje ustawienia
        /// </summary>
        private static void Settings()
        {
            Console.ReadKey();
            Console.Clear();
            Console.ResetColor();
        }
        
        /// <summary>
        /// wypisujemy komunikat zależny od wieku
        /// </summary>
        private static void Age()
        {
            Console.Write("Wpisz wiek: ");
            int age;
            bool result = int.TryParse(Console.ReadLine(), out age);
            Console.WriteLine(age);


            if (result == false)
            {
                Console.WriteLine("Wiek musi być cyfrą np: 18");
            }else if (age > 18)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Wypij Flaszkę");
            }
            else
            {
                Console.WriteLine("Pij Mleko");
            }
        }
        
        /// <summary>
        /// Wypisuje w consoli imię użytkownika
        /// </summary>
        /// <returns></returns>
        private static string Greeting()
        {
            Console.Write("Wpisz swoje imię: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name);
            return name;
        }
    }
}
