using System;

namespace Inlämningsuppgift_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random genertator = new Random();
            int randomTal = genertator.Next(1, 100), gissningar=0;
            int tal = 0;
            while(tal != randomTal)
            {
                Console.WriteLine("Skriv ett tal mellan 1 och 100 ");
                tal = Convert.ToInt32(Console.ReadLine());

                if (tal > randomTal)
                    Console.WriteLine("Gissa ett lägre tal");
                else if (tal < randomTal)
                    Console.WriteLine("Gissa ett högre tal");


                gissningar++;
            }
                Console.WriteLine("Du har gissat rätt");
                Console.WriteLine("Du gissade" + gissningar + "gånger");
            }

        }
    }

