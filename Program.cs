Random randint = new Random();
int guessint = randint.Next(1, 100);
int guess1 = 0;
while (true)
{
    while (guess1 != guessint)
    {
        Console.WriteLine("What is your guess:");
        string guess2 = Console.ReadLine();
        if (guess2 == "restart")
        {
            Console.WriteLine("Restarting...");
            guessint = randint.Next(1, 100);
        }
        else if (guess2 == "r")
        {
            Console.WriteLine("Restarting...");
            guessint = randint.Next(1, 100);
        }
        else if (!int.TryParse(guess2, out guess1))
        {
            Console.WriteLine("Error, cannot do string.");
        }
        else if (guess1 < guessint)
        {
            Console.WriteLine("Too low");
        }
        else if (guess1 > guessint)
        {
            Console.WriteLine("Too high");
        }
    }
    if (guess1 == guessint)
    {
        Console.WriteLine("Well done, restarting...");
        guessint = randint.Next(1, 100);
    }
}