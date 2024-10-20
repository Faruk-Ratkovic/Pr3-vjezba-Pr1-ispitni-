using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {

        public static int countOcurrences(string sentence, string word)
        {
            string[] words = sentence.Split(" ");
            int count = 0;
            for (int i = 0; i < words.Count(); i++)
            {
                if (words[i]==word)
                {
                    count++;
                }
                
            }
         
                return count;
        }
        public static void Main()
        {
            string? sentence;
            Console.WriteLine("Hello, please enter a sentence");
           
            sentence = Console.ReadLine();
            Console.WriteLine("Now please enter a word you want me to find");
            string? word;
            word= Console.ReadLine();

            if (sentence != null && word != null) 
            {
                Console.WriteLine("In the sentence: " + sentence + " word " + word + " can be found " + countOcurrences(sentence, word) + " times ");
            }
           
        }
    }
}

