using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");
        List<int> numbers = new List<int>();

        int userNumber=-1;
        do
        {
        Console.WriteLine("type a list of numbers. type 0 to stop. ");
        string userList=Console.ReadLine();
        userNumber=int.Parse(userList);
        
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        } while(userNumber!=0);

        int sum=0;
        foreach (int number in numbers)
        {
            sum+=number;
        }
        
        //int sum=numbers.Sum();
        Console.WriteLine($"the sum is {sum}");

        double average=numbers.Average();
        Console.WriteLine($"the average is {average}");

        int biggestNumber = numbers.Max();
        Console.WriteLine($"the biggest number is {biggestNumber}");
        Console.ReadLine();
        
    }
}
