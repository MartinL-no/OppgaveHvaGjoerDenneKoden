using System;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;

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
                
                for (var i = 0; i < range; i++)
                {
                    if (counts[i] > 0)
                    {
                        var character = (char)i;
                        var average = Math.Round((float) counts[i] / total * 100);
                        string averageText = average.ToString() + "%";
                        
                        Console.WriteLine(character + " - " + JustifyText(averageText));
                    }
                }
                static string JustifyText(string text)
                {
                    string spaces = "";
                    for (int i = text.Length; i < 4; i++)
                    {
                        spaces += " ";
                    }
                    return spaces + text;
                }    
            }
        }
    }
}