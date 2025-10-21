using System.Collections.Generic;
namespace Template_Method
{
    class TextFileProcessor : FileProcessor
    {
        private List<string> lines = new List<string>();

        protected override void ReadData()
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                lines.Add(line);
            }
            Console.WriteLine("Textdatei gelesen.");
        }

        protected override void ProcessData()
        {
            Console.WriteLine("Verarbeite Textdatei:");
            foreach (var line in lines)
            {
                if (!string.IsNullOrWhiteSpace(line))
                {
                    Console.WriteLine($"  -> {line}");
                }
            }
        }
    }
}
