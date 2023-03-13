namespace Finn_meg_en_hobby
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int minRandom = 0;
            int maxRandom = 5;
            string person = "bruker";
            Console.WriteLine("Hvem har lyst på hobby?");
            while (!string.IsNullOrWhiteSpace(person))
            {
                person = Console.ReadLine();
                int randomNum = randomizer(minRandom, maxRandom);
                string[] hobbies = new string[5] { "bli gamer", "strikke genser", "lære koding", "trene til maraton", "drive strikkhopp"};
                Console.WriteLine("Ja, " + person + " kan jo kanskje " + hobbies[randomNum] + "?");
            }

        }

        private static int randomizer(int minRandom, int maxRandom)
        {
            Random rnd = new Random();
            int num = rnd.Next(minRandom, maxRandom);
            return num;
        }
    }
}