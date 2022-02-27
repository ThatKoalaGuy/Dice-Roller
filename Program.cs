static void Random()
{
    Random rand = new Random();
    int randomNumber = rand.Next(1, 7);

    Console.WriteLine(randomNumber);
    Console.WriteLine("Do you need another number? ENTER yes, BACKSPACE 2-times no");
}

Random();

while (true)
{
    if (Console.ReadKey().Key == ConsoleKey.Enter)
    {
        Random();
    }

    else if (Console.ReadKey().Key == ConsoleKey.Backspace)
    {
        Environment.Exit(0);
    }
}