Random rnd= new Random();

int cpuRandom;

bool LoopActive = true;

while (LoopActive) 
{
    cpuRandom = rnd.Next(1, 4);
    Console.WriteLine("Make a guess:");
    int userNumber = Int32.Parse(Console.ReadLine());

    if (userNumber == cpuRandom) 
    {
        Console.WriteLine("Congratulations, you won!");
    }
    else 
    {
        Console.WriteLine("Oops. Try again...");
    }

}