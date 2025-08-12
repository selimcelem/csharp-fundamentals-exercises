//1.Prompt the user to enter a sentence.

//2. Split the sentence into words.

//  Hint: Use string.Split() with ' ' (space) as the separator.

//3. Create a Dictionary<string, int> to count how often each word appears.

//4. Loop through the words:

//  If the word is already in the dictionary, increment its count

//  Otherwise, add it with value 1

//5. Print the word counts

using System;

class WordCounter
{
    static void Main(string[] args)
    {
        Console.WriteLine("Write a sentence: ");
        string? sentence = Console.ReadLine();

        if(sentence == null)
        {
            Console.WriteLine("No input provided.");
            return;
        }

        string[] words = sentence.ToLower().Split(new[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);

        Dictionary<string, int> wordCounts = new Dictionary<string, int>();
        int totalWordCount = 0;

        foreach (string word in words)
        {
            string cleanWord = word.Trim(new char[] { '.', ',', '!', '?', ';', ':' });

            if (wordCounts.ContainsKey(cleanWord))
            {
                wordCounts[cleanWord]++;
            }
            else
            {
                wordCounts[cleanWord] = 1;
            }
            totalWordCount++;
        }
        foreach (var entry in wordCounts)
        {
            Console.WriteLine($"'{entry.Key}' appears {entry.Value} time(s)");
        }
        Console.WriteLine($"Total word count: {totalWordCount}");
    }
}