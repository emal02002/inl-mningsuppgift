using System;

namespace Inlämningsuppgift_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random genertator = new Random();
            int randomTal = genertator.Next(1, 100);
            while(Tal != randomTal)
            {
                Console.WriteLine("Skriv ett tal mellan 1 och 100 ");
                int tal = int.Parse(Console.ReadLine());
                if(tal > randomTal)
                    Console.WriteLine("Det gissade talet är")



            }



        }
    }
}
