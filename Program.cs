using System;

namespace Template_Method
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Verarbeitung der Textdatei:");
            FileProcessor txtProcessor = new TextFileProcessor();
            txtProcessor.ProcessFile("data.txt");

            Console.WriteLine("\nVerarbeitung der CSV-Datei:");
            FileProcessor csvProcessor = new CsvFileProcessor();
            csvProcessor.ProcessFile("data.csv");
        }
    }
}