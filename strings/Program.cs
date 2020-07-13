using System;

namespace strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation?'";
            Console.WriteLine("Enter a word");
            string searchTerm = Console.ReadLine();
            if (sentence.ToLower().Contains(searchTerm.ToLower()))
            {
                Console.WriteLine("true");
                Console.WriteLine("The index is " + sentence.IndexOf(searchTerm));
            } else
            {
                Console.WriteLine("false");
            }
        }
    }
}
