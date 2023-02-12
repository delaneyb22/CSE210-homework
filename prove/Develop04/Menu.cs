using System;
public class Menu
{

    public Menu(){
    }
    public void Write()
    {
        Console.Write("Would you like a prompt? (y/n) ");
        string userAnswer = Console.ReadLine();
        if (userAnswer == "y")
    {
        Console.WriteLine("This is a prompt!");
 // We would want to replace this with something like PromptGenerater.GenerateNew(prompt);
    }
        Console.WriteLine(">>>");
        string writeEntry = Console.ReadLine();
        
        Entry workingEntry = new Entry();
        workingEntry.Write(writeEntry);
    }
    
     
 
}
   
    //public void CreateEntry(Boolean withPrompt){
      //  if withPrompt{
      //      PromptGenerator.GenerateNew();
      //  }
   // }
