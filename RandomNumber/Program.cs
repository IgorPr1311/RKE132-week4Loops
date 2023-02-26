Random rnd= new Random();

int myRandomNum;

int myRandomSum = 0;

for (int i = 0; i < 3; i++)
{

    myRandomNum = rnd.Next(1, 5);
    myRandomSum = myRandomSum + myRandomNum;
    Console.WriteLine($"My random number is:{myRandomNum}!");
}
Console.WriteLine($"Random sum total is:{myRandomSum}");