using System;
using System.Threading;

class Program
{
    static void Main()
    {
        // Handler für das Abfangen von Tastenereignissen (zum Beenden des Programms)
        Console.CancelKeyPress += (_, args) =>
        {
            args.Cancel = true;
            Environment.Exit(0);
        };

        // Hauptschleife des Programms
        while (true)
        {
            // Zeichne den Tannenbaum mit wechselnden Farben
            DrawChristmasTreeWithColor();

            // Warte eine Sekunde, bevor die Farbe erneut geändert wird
            Thread.Sleep(1000);

            // Lösche die Konsole für die nächste Ausgabe
            Console.Clear();
        }
    }

    // Funktion zum Zeichnen des Tannenbaums mit wechselnden Farben
    static void DrawChristmasTreeWithColor()
    {
        // Höhe des Tannenbaums
        int treeHeight = 10;

        // Schleife für jede Zeile des Tannenbaums
        for (int i = 0; i < treeHeight; i++)
        {
            // Leerzeichen vor den Nullen für die Verschiebung
            for (int j = 0; j < treeHeight - i - 1; j++)
            {
                Console.Write(" ");
            }

            // Schleife für jeden einzelnen Character in der aktuellen Zeile
            for (int k = 0; k < 2 * i + 1; k++)
            {
                // Setze die Farbe für jeden einzelnen Character
                Console.ForegroundColor = GetRandomConsoleColor();
                Console.Write("0");
            }

            // Neue Zeile für den nächsten Schritt im Tannenbaum
            Console.WriteLine();
        }
    }

    // Funktion zum Zufälligauswählen einer Konsolenfarbe
    static ConsoleColor GetRandomConsoleColor()
    {
        // Array aller verfügbaren Konsolenfarben
        ConsoleColor[] consoleColors = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));

        // Zufällige Auswahl einer Farbe
        Random random = new Random();
        return consoleColors[random.Next(consoleColors.Length)];
    }
}