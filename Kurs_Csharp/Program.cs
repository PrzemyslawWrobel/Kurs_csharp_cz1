using System;

namespace Kurs_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
           // string name = args[0];
           // Console.WriteLine("Hello " + name);

            foreach (var item in args)
            {
                Console.WriteLine("Hello " + item);
            }

            //  fdsr
        }
    }
}
