using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        
        Console.Write("What is your grade percentage? ");
        string userGrade=Console.ReadLine();
        float gradePercentage =float.Parse(userGrade);

        if (gradePercentage >=90)
        {
            Console.Write("Letter=A");
            //string letter ="A";
        }
        else if (gradePercentage >= 80)
        {
            Console.Write("Letter=B");
            //string letter="B";
        }
        else if(gradePercentage >= 70)
        {
            Console.Write("Letter=C");
            //string letter="C";
        }
        else if (gradePercentage>=60)
        {
            Console.Write("Letter=D");
            //string letter="D";
        }
        else
        {
            Console.Write("Letter=F");
            //string letter="F";
        }

        //Console.WriteLine($"your grade is {letter}.");

        if(gradePercentage>=70)
        {
            Console.WriteLine($"Congrats, you passed!");
        }
        else
        {
            Console.WriteLine($"Keep trying to improve your grade :)! ");
        }

    }
}