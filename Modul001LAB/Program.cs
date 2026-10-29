namespace Modul001LAB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double meter = 10000;
            int stunden = 0;
            int minuten = 45;
            int sekunden = 0;

            double gesamtSekunden =
                stunden * 3600 +
                minuten * 60 +
                sekunden;

            double meterProSekunde = meter / gesamtSekunden;
            double kilometerProStunde = meterProSekunde * 3.6;
            double meilenProStunde = kilometerProStunde * 0.621371;

            Console.WriteLine($"m/s  : {meterProSekunde:F2}");
            Console.WriteLine($"km/h : {kilometerProStunde:F2}");
            Console.WriteLine($"mph  : {meilenProStunde:F2}");

        }
    }
}
