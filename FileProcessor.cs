using System;
using System.IO;
namespace Template_Method
{
    abstract class FileProcessor
    {
        public void ProcessFile(string path)
        {
            OpenFile(path);
            ReadData();
            ProcessData();
            CloseFile();
        }

        protected StreamReader reader;

        protected void OpenFile(string path)
        {
            Console.WriteLine($"Öffne Datei: {path}");
            reader = new StreamReader(path);
        }

        protected void CloseFile()
        {
            Console.WriteLine("Schließe Datei.");
            reader.Close();
        }

        protected abstract void ReadData();
        protected abstract void ProcessData();
    }
}
