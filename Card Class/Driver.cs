

namespace Card_Class
{
    class Driver
    {
        static void Main(string[] args)
        {
            Card defaultCard = new Card();
            Console.WriteLine($"The default card is:{defaultCard.ToString()}");

            int input = 0;
            Console.Write("Please type an integer between 1 and 52. Type -1 to stop:");
            input = int.Parse(Console.ReadLine());

            while (input != -1)
            {
                Card card = new Card(input);
                Console.WriteLine($"The card matching {input} is the {card.ToString()}");
                Console.Write("Please type an integer between 1 and 52. Type -1 to stop:");
                input = int.Parse(Console.ReadLine());
            }

            ShowDeck();
        }


        //loop to keep prompting the user unless they enter -1
        private static void ShowDeck()
        {
            Console.WriteLine("\nAll possible cards in a deck:");
            for (int i = 0; i < 52; i++)
            {
                Card card = new Card(i);
                Console.WriteLine(card.ToString());
            }
        }
    }
}