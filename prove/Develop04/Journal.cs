using System;
public class Journal

{
    public List<Entry> Index;
    public Journal()
    {
    }

    public void Display(string type, string name)
    {
        if (type== "entry")
        {
            Console.WriteLine("hello world");
        }
        
    }


}