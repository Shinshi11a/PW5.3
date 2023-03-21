using System;

interface IFilter
{
    string Execute(string textLine);
}

class DigitFilter : IFilter
{
    public string Execute(string textLine)
    {
        string result = "";
        foreach (char c in textLine)
        {
            if (!Char.IsDigit(c))
            {
                result += c;
            }
        }
        return result;
    }
}

class LetterFilter : IFilter
{
    public string Execute(string textLine)
    {
        string result = "";
        foreach (char c in textLine)
        {
            if (!Char.IsLetter(c))
            {
                result += c;
            }
        }
        return result;
    }
}

class Program
{
    static void Main(string[] args)
    {
        IFilter digitFilter = new DigitFilter();
        IFilter letterFilter = new LetterFilter();

        string textLine = "Th1s 1s s0me t3xt w1th d1g1ts";
        Console.WriteLine($"Оригинальная строка: {textLine}");

        string filteredText = digitFilter.Execute(textLine);
        Console.WriteLine($"Строка после фильтра цифр: {filteredText}");

        filteredText = letterFilter.Execute(textLine);
        Console.WriteLine($"Строка после фильтра букв: {filteredText}");
    }
}
