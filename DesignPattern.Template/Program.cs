using System.Collections.Generic;

namespace DesignPattern.Template
{
    class Program
    {
        static void Main()
        {
            List<ImportData> importDataList = new List<ImportData> 
            {
                new ImportXmlData(), 
                new ImportCSVData()
            };

            foreach (ImportData dataSource in importDataList)
            {
                dataSource.Execute();
            }
        }
    }
}
