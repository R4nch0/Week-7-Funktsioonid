using System;

namespace UserNameDataTask
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada eesnime
            //programm küsib kasutajal siesestada numbrit 1-3
            //kui kasutaja sisestab "1", siis kuvatakse kasutaja eesnime tagurpidi
            //kui kasutaja valib "2", siis kuvatakse kasutaja eesnime esimest tähte
            //kui kasutaja valib "3", siis kuvatakse kasutaja eesnime pikkust
            Console.WriteLine("sisesta oma eesnimi");
            string userName = Console.ReadLine();
            Console.WriteLine("sisesta number 1-3");
            int number = Convert.ToInt32(Console.ReadLine());

            switch (number)
            {
                case (1):
                    Backwards(userName);
                    break;
                case (2):
                    FirstLetter(userName);
                    break;
                case (3):
                    NameLength(userName);
                    break;
                default:
                    Console.WriteLine("Vale väärtus!");
                    break;
            }

        }

        public static void Backwards(string userName)
        {
            for (int i = userName.Length - 1; i >= 0; i--)
            {
                Console.Write(userName[i]);
            }
        }

        public static void FirstLetter(string userName)
        {
            Console.WriteLine($"Sinu eesnime esimene täht on {userName[0]}");
        }

        public static void NameLength(string userName)
        {
            Console.WriteLine($"Sinu nimi on {userName.Length} sümbolit pikk.");
        }

    }
}
