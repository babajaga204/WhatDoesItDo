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
        int totalLetters = 0;
        string text = "something";
        while (!string.IsNullOrWhiteSpace(text))
        {
            text = Console.ReadLine().ToLower();
            UpdateCharacters(counts, text, totalLetters);
            ShowCounts(range, counts, totalLetters);
        }
    }

    private static void ShowCounts(int range, int[] counts, int totalLetters)
    {
        for (var i = 0; i < range; i++)
        {
            if (counts[i] <= 0) continue;
            var character = (char)i;
            var percentage = 100 * (double)counts[i] / totalLetters;
            string output = character + " - " + percentage.ToString("P") + "%";
            Console.CursorLeft = Console.BufferWidth - output.Length - 1;
            Console.WriteLine(output);
        }
    }

    private static void UpdateCharacters(int[] counts, string text, int totalLetters)
    {
        foreach (var character in text ?? string.Empty)
        {
            totalLetters++;
            counts[(int)character]++;
        }
    }
}