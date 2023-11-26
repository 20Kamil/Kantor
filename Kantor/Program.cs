using System;

class Program
{
    static void Main()
    {
        // Kursy wymiany walut
        double kursEURtoUSD = 1.18;
        double kursCHFtoUSD = 1.10;
        double kursGBPtoUSD = 1.38;

        // Dane użytkownika
        Console.Write("Podaj kwotę w PLN: ");
        double kwotaPLN = Convert.ToDouble(Console.ReadLine());

        Console.Write("Podaj walutę docelową (EUR, CHF, GBP): ");
        string walutaDocelowa = Console.ReadLine().ToUpper();

        // Przeliczenie na walutę pośrednią (USD)
        double kwotaUSD = PrzeliczNaUSD(kwotaPLN);

        // Przeliczenie na walutę docelową
        double wynik = 0;
        switch (walutaDocelowa)
        {
            case "EUR":
                wynik = kwotaUSD / kursEURtoUSD;
                break;
            case "CHF":
                wynik = kwotaUSD / kursCHFtoUSD;
                break;
            case "GBP":
                wynik = kwotaUSD / kursGBPtoUSD;
                break;
            default:
                Console.WriteLine("Nieprawidłowa waluta docelowa.");
                return;
        }

        // Wyświetlenie wyniku w konsoli
        Console.WriteLine($"Wynik przewalutowania: {wynik:F2} {walutaDocelowa}");

        // Oczekanie na naciśnięcie klawisza przed zamknięciem konsoli
        Console.ReadKey();
    }

    static double PrzeliczNaUSD(double kwotaPLN)
    {
        // Załóżmy stały kurs wymiany PLN na USD
        double kursPLNtoUSD = 0.27;
        return kwotaPLN * kursPLNtoUSD;
    }
}