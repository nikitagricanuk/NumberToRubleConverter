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