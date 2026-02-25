namespace NumberToRubleConverter;

class Program
{
    static void Main(string[] args)
    {
        int kopeks = int.Parse(Console.ReadLine());
        int rublesFinal = 0;
        int kopeksFinal;
        if (kopeks >= 100 && kopeks <= 200) // 100 <= kopeks <= 200
        {
            rublesFinal += 1;
            kopeks -= 100;
            kopeksFinal = kopeks;
        }
        else if (kopeks >= 200 && kopeks <= 300)
        {
            rublesFinal += 2;
            kopeks -= 200;
            kopeksFinal = kopeks;
        }
        else if (kopeks >= 300 && kopeks <= 400)
        {
            rublesFinal += 3;
            kopeks -= 300;
            kopeksFinal = kopeks;
        }
        else
        {
            kopeksFinal = kopeks;
        }
        Console.WriteLine(rublesFinal + " рублей " + kopeksFinal + " копеек");
    }
}

public class Converter
{
    public static int GetRubles(int kopeks)
    {
        int rublesFinal = 0;
        if (kopeks >= 100 && kopeks <= 200) // 100 <= kopeks <= 200
        {
            rublesFinal += 1;
            kopeks -= 100;
        }
        else if (kopeks >= 200 && kopeks <= 300)
        {
            rublesFinal += 2;
            kopeks -= 200;
        }
        else if (kopeks >= 300 && kopeks <= 400)
        {
            rublesFinal += 3;
            kopeks -= 300;
        }

        return rublesFinal;
    }
    public static int GetKopeks(int number)
    {
        if (number >= 1000)
        {
            number -= 1000;
        }

        if (number >= 100)
        {
            number -= 100;
        }
        return number;
    }
}