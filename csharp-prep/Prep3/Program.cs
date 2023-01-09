using System;
Random randomGenerator = new Random();
int number = randomGenerator.Next(1, 11);

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the magic number? ");
        string magic_number=Console.ReadLine();
        float number=float.Parse(magic_number);


        Console.Write("What is your guess? ");
        string ask_user=Console.ReadLine();
        float guess=float.Parse(ask_user);
    }
}