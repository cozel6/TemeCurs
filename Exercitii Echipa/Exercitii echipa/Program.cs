using System;
using System.Text;


class Program
{
    static void Main(string[] args)
    {

        string text = "Input: Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.";
        FormatText(text, 50);
    }

    static void FormatText(string text, int maxWidth)
    {
        StringBuilder formattedText = new StringBuilder();
        int currentIndex = 0;

        while (currentIndex < text.Length)
        {
            int lineLenght =  Math.Min(maxWidth, text.Length - currentIndex);
            string line = text.Substring(currentIndex, lineLenght);
            formattedText.AppendLine(line);
            currentIndex += lineLenght;
            Console.WriteLine(formattedText.ToString());

        }
    }
}