namespace BankkontoLAB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                =========================================================
                LAB: Bankkonto mit Dispokredit
                =========================================================

                Ziel:
                Erstelle eine Klasse "Bankkonto", die ein Bankkonto
                mit Kontoinhaber, Kontostand und Dispolimit verwaltet.

                ---------------------------------------------------------
                Anforderungen
                ---------------------------------------------------------

                1. Erstelle eine Klasse Bankkonto.

                2. Die Klasse soll folgende Eigenschaften (Auto-Properties besitzen:

                   - Vorname(string)
                   - Nachname (string)
                   - Kontostand (decimal)
                   - Dispolimit (decimal) 

                3. Implementiere einen Konstruktor, der folgende
                   Informationen beim Erstellen eines Kontos erhält:

                   - Vorname
                   - Nachname
                   - Startguthaben
                   - Dispolimit

                4. Implementiere eine Methode:

                   Einzahlen(decimal betrag)

                   Diese Methode erhöht den Kontostand um den
                   übergebenen Betrag.

                ---------------------------------------------------------

                5. Implementiere eine Methode:

                   Abheben(decimal betrag)

                   Regeln:

                   - Der Betrag soll vom Kontostand abgezogen werden.
                   - Das Konto darf das Dispolimit nicht überschreiten.

                   Beispiel:

                   Kontostand: 100 €
                   Dispolimit: 500 €

                   Erlaubter Mindeststand:
                   -500 €

                   Eine Abhebung von 550 € wäre möglich.

                   Neuer Kontostand:
                   -450 €

                   Eine weitere Abhebung von 100 € wäre NICHT möglich,
                   da der Kontostand dann auf -550 € sinken würde.

                   In diesem Fall soll eine passende Meldung
                   ausgegeben werden.

                ---------------------------------------------------------

                6. Implementiere eine Methode:

                   KontostandAnzeigen()

                   Die Methode soll folgende Informationen ausgeben:

                   Vorname
                   Nachname
                   Kontostand
                   Dispolimit

                ---------------------------------------------------------

                7. Erstelle im Main-Programm ein Objekt der Klasse.

                   Beispiel:

                   Vorname: Max
                   Nachname: Mustermann
                   Startguthaben: 1000 €
                   Dispolimit: 500 €

                ---------------------------------------------------------

                8. Führe folgende Aktionen durch:

                   Kontostand anzeigen

                   200 € einzahlen

                   Kontostand anzeigen

                   1500 € abheben

                   Kontostand anzeigen

                   200 € abheben

                   Kontostand anzeigen

                ---------------------------------------------------------

                Bonus-Aufgabe 1
                ---------------------------------------------------------

                Erstelle eine Eigenschaft:

                   VollerName

                Die Eigenschaft soll automatisch:

                   Vorname + " " + Nachname

                zurückgeben.

                ---------------------------------------------------------

                Bonus-Aufgabe 2
                ---------------------------------------------------------

                Erstelle eine Methode:

                   VerfuegbarerBetragAnzeigen()

                Beispiel:

                   Kontostand = 100 €
                   Dispolimit = 500 €

                Dann sollen noch 600 € verfügbar sein.

                ---------------------------------------------------------

                Bonus-Aufgabe 3
                ---------------------------------------------------------

                Verhindere:

                   - negative Einzahlungen
                   - negative Abhebungen
                   - Dispolimit kleiner 0

                Gib jeweils sinnvolle Fehlermeldungen aus.

                =========================================================
                Erwartete OOP-Konzepte
                =========================================================

                ✓ Klasse
                ✓ Objekt
                ✓ Eigenschaften
                ✓ Konstruktor
                ✓ Methoden
                ✓ Bedingungen (if)
                ✓ this-Schlüsselwort
                ✓ Datenkapselung
                ✓ Berechnungen mit decimal

                =========================================================
                */
        }
    }
}
