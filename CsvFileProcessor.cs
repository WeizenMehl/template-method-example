using System.Collections.Generic;
namespace Template_Method
{
    class CsvFileProcessor : FileProcessor
    {
        private List<string[]> rows = new List<string[]>();

        protected override void ReadData()
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                var columns = line.Split(',');
                rows.Add(columns);
            }
            Console.WriteLine("CSV-Datei gelesen.");
        }

        protected override void ProcessData()
        {
            Console.WriteLine("Verarbeite CSV-Datei:");
            foreach (var row in rows)
            {
                Console.WriteLine($"  -> {string.Join(" | ", row)}");
            }
        }
    }
}
