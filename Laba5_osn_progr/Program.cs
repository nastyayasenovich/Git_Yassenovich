using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.Write("Введіть текст: ");
        string text = Console.ReadLine();

        char[] chars = text.ToCharArray();
        int maxCount = 0;
        char maxChar = '\0';

        foreach (char c in chars)
        {
            int count = 0;
            foreach (char c2 in chars)
            {
                if (c == c2)
                {
                    count++;
                }
            }
            if (count > maxCount)
            {
                maxCount = count;
                maxChar = c;
            }
        }

        Console.WriteLine($"Найбільша кількість однакових символів: {maxCount}, символ: {maxChar}");
    }
}

