using System;
using System.Collections.Generic;


namespace Dictionary_of_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Create a dictionary with key value pairs to
                represent words (key) and its definition (value)
            */
            Dictionary<string, string> wordsAndDefinitions = new Dictionary<string, string>(){
                {"Deep", "very intense or extreme"},
                {"Deeps", "extending far down from the top or surface"},
                {"Depths", "the sea"},
                {"Deepth", "far down or in; deeply"}
            };

            // Add several more words and their definitions
            wordsAndDefinitions.Add("Awesome", "The feeling of students when they are learning C#");
            wordsAndDefinitions.Add("Cool", "The feeling of students when they are learning C#");
            wordsAndDefinitions.Add("Super", "The feeling of students when they are learning C#");

            /*
                Use square brackets to get the definition of two of the
                words and then output them to the console
            */
            Console.WriteLine($"The definition of Deep is {wordsAndDefinitions["Deep"]}");

            /*
                Below, loop over the wordsAndDefinitions dictionary to get the following output:
                The definition of (WORD) is (DEFINITION)
                The definition of (WORD) is (DEFINITION)
                The definition of (WORD) is (DEFINITION)
            */
            foreach (KeyValuePair<string, string> word in wordsAndDefinitions)
            {
                Console.WriteLine($"The definition of {word.Key} is {word.Value}");
            }
        }
    }
}
