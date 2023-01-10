namespace WhatDoesItDo;
class Program
{
    static void Main(string[] args)
    {
        ReadTextAndShowCharCount(250);
    }

    private static void ReadTextAndShowCharCount(int range)
    {
        var counts = new int[range];
        string text = "something";
        while (!string.IsNullOrWhiteSpace(text))
        {
            text = Console.ReadLine();
            UpdateCharacters(counts, text);
            ShowCounts(range, counts);
        }
    }

    private static void ShowCounts(int range, int[] counts)
    {
        for (var i = 0; i < range; i++)
        {
            if (counts[i] > 0)
            {
                var character = (char)i;
                Console.WriteLine("\"" + character + "\" - " + counts[i]);
            }
        }
    }

    private static void UpdateCharacters(int[] counts, string text)
    {
        foreach (var character in text ?? string.Empty)
        {
            counts[(int)character]++;
        }
    }
}