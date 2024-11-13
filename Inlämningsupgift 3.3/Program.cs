using System;
namespace InlämningsUpgifter_3._3
{
    class program
    {
        static void Main(string[] args)
        {
            Console.Write("Hur länge vill du hyra bilen? Svara i timmar");
            int timmar = int.Parse(Console.ReadLine());

            int kostnadPerTimme = 80;
            int maxKostnadPerDag = 950;

            int totalKostnad = timmar * kostnadPerTimme;

            if (totalKostnad > maxKostnadPerDag)
            {
                totalKostnad = maxKostnadPerDag;
            }

            Console.WriteLine($"Kostnaden för att hyra bilen i {timmar} timmar är: {totalKostnad} kronor.");
        }
    }
}