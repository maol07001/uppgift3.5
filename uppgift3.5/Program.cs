using System;
namespace uppgift_3._5
{
    class Program
    {
        static void Main()
        {
            Console.Write("Skriv in det första talet: ");
            int tal1 = int.Parse(Console.ReadLine());

            Console.Write("Skriv in det andra talet: ");
            int tal2 = int.Parse(Console.ReadLine());

            Console.WriteLine("\nVälj ett räknesätt:");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraktion");
            Console.WriteLine("3. Multiplikation");
            Console.WriteLine("4. Division");

            int val = int.Parse(Console.ReadLine());

            int resultat = 0;

            switch (val)
            {
                case 1: 
                    resultat = tal1 + tal2;
                    Console.WriteLine("Resultatet av additionen är: " + resultat);
                    break;

                case 2:  
                    resultat = tal1 - tal2;
                    Console.WriteLine("Resultatet av subtraktionen är: " + resultat);
                    break;

                case 3:  
                    resultat = tal1 * tal2;
                    Console.WriteLine("Resultatet av multiplikationen är: " + resultat);
                    break;

                case 4:  
                    if (!(tal2 == 0))  
                    {
                        resultat = tal1 / tal2;
                        Console.WriteLine("Resultatet av divisionen är: " + resultat);
                    }
                    else
                    {
                        Console.WriteLine("Kan inte dela med noll!");
                    }
                    break;

                default:
                    Console.WriteLine("Ogiltigt val!");
                    break;
            }
        }
    }
}
