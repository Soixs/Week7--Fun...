using System;

namespace UserNameDataTask
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada eesnime;
            //programm küsib kasutajal sisestada numbrit 1-3;
            //kui kasutaja sisestab '1', siis kuvatakse kasutaja eesnime tagurpidi;
            //kui kasutaja valib '2', siis kuvatakse kasutaja eesnime esimest tähte;
            //kui kasutaja valib '3', siis kuvatakse kasutaja eesnime pikkust;

            Console.WriteLine("Sisesta oma eesnimi:");
            string userName = Console.ReadLine();

            Console.WriteLine("Vali üks number 1-st 3-ni.");
            char userOperator = Convert.ToChar(Console.ReadLine());

            switch (userOperator)
            {
                case '1':
                    UserNameBackwards(userName);
                    break;
                case '2':
                    UserFirstNameLetter(userName);
                    break;
                case '3':
                    UserNameLenght(userName);
                    break;
                default:
                    Console.WriteLine("Kena päeva!");
                    break;
            }
        }

        public static void UserNameBackwards(string UserInput)
        {
            for (int i = UserInput.Length - 1; i >= 0; i--)
            {
                Console.Write(UserInput[i]);
            }
        }

        public static void UserFirstNameLetter(string UserInput)
        {
            Console.WriteLine($"Sinu eesnime esimene täht on {UserInput[0]}.");
        }

        public static void UserNameLenght(string UserInput)
        {
            Console.WriteLine($"Sinu nimi on {UserInput.Length} sümbolit pikk.");
        }
    }
    
}
