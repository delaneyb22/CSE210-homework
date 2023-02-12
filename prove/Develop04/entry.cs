using System.IO;

public class Entry{
        public string _title="";
        public string _dateOfEntry="";
        public string _content="";
        public int _index;

        public Entry(){

        }

    public void Write(string textInput)
    {
        Console.Write("Please input a filename: ");
        string fileName = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine(textInput);
        }
    }
}