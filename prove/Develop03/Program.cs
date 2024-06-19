
        
using System;

class Program
{
    static void Main(string[] args)
    {
        Reference scriptureReference = new Reference("Psalms", "3", "7-8");
        Scripture scripture = new Scripture(scriptureReference, "Arise,O Lord; save me, O my God: for thou hast smitten all mine enemies upon the cheek bone;thou hast broken the teeth of the ungodly.Salvation belongeth unto the Lord:thy blessing is upon thy people.Selah.");
        ScriptureMemorizer scriptureMemorizer = new ScriptureMemorizer(scripture);
        

        string userInput = "";

        while (userInput != "quit" && scriptureMemorizer.hasWordsLeft() == true)
        {
            Console.Clear();
            Console.WriteLine(string.Format("{0} {1}", scriptureReference.toString(), scriptureMemorizer.toString()));
            Console.WriteLine();
            Console.WriteLine("Welcome to Scripture Memorizer Game! Press enter to continue ,type 'quit' to finish.");
            userInput = Console.ReadLine();
            scriptureMemorizer.removeWordsFromText();
        }
        
        Console.Clear();
        Console.WriteLine(string.Format("{0} {1}", scriptureReference.toString(), scriptureMemorizer.toString()));
        Console.WriteLine();
        Console.WriteLine("Great job!");
    }
}
    
