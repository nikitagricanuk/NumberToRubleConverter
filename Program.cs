namespace NumberToRubleConverter;

class Program
{
    static void Main(string[] args)
    {
        int kopeks = int.Parse(Console.ReadLine());
        Console.WriteLine(Converter.GetResult(kopeks));
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
                
        if (number >= 300)
        {
            number -= 300;
        }
        
        if (number >= 200)
        {
            number -= 200;
        }
        
        if (number >= 100)
        {
            number -= 100;
        }
        return number;
    }
    public static string GetResult(int number)
    {
        int rubles = GetRubles(number);
        int kopeks = GetKopeks(number);

        string rublesWord = GetDeclensionRubles(rubles);
        string kopeksWord = GetDeclensionKopeks(kopeks);

        return $"{rubles} {rublesWord} {kopeks} {kopeksWord}";
    }

    private static string GetDeclensionRubles(int n)
    {
        int n2 = n % 100;

        if (n2 >= 11 && n2 <= 14)
            return "рублей";

        int n1 = n % 10;

        if (n1 == 1)
            return "рубль";

        if (n1 >= 2 && n1 <= 4)
            return "рубля";

        return "рублей";
    }
    
    private static string GetDeclensionKopeks(int n)
    {
        int n2 = n % 100;

        if (n2 >= 11 && n2 <= 14)
            return "копеек";

        int n1 = n % 10;

        if (n1 == 1)
            return "копейка";

        if (n1 >= 2 && n1 <= 4)
            return "копейки";

        return "копеек";
    }
}