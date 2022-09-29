using System;

namespace Abstraction
{
    class Program
    {
        interface IExportData
        {
            void Export();
        }

        class TextExport : IExportData
        {
            public void Export()
            {
                Console.WriteLine("Export data to .txt file");
            }
        }

        class CsvExport : IExportData
        {
            public void Export()
            {
                Console.WriteLine("Export data to .csv file");
            }
        }

        class Application
        {
            private readonly IExportData _exportData;

            public Application(IExportData exportData)
            {
                _exportData = exportData;
            }

            public void ExportData()
            {
                _exportData.Export();
            }
        }
        static void Main(string[] args)
        {
            Application app = new Application(new TextExport());
            app.ExportData();
            Console.ReadKey();
        }
    }
}
