using System;
using System.Linq;

namespace OppgaveHvaGjoerDenneKoden
{
    class Program
    {
        static void Main(string[] args)
        {
            var range = 250;
            var counts = new int[range];
            string text = "something";
            while (!string.IsNullOrWhiteSpace(text))
            {
                text = Console.ReadLine();
                string lowerCasedText = text.ToLowerInvariant();

                foreach (var character in lowerCasedText ?? string.Empty)
                {
                    counts[(int)character]++;
                }
                
                int total = counts.Sum();
                Console.WriteLine("total: " + total);
                
                for (var i = 0; i < range; i++)
                {
                    if (counts[i] > 0)
                    {
                        var character = (char)i;
                        var average = (float) counts[i] / total * 100;
                        
                        Console.WriteLine(character + " - " + average + "%");
                    }
                }
            }
        }
    }
}