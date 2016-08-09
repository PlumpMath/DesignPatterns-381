using System.Collections.Generic;

namespace DesignPattern.Strategy
{
    class Program
    {
        static void Main()
        {
            List<IImportData> importDataList = new List<IImportData> 
            {
                new ImportXmlData(), 
                new ImportCSVData()
            };

            foreach (IImportData importData in importDataList)
            {
                ImportDataHandler dataHandler = new ImportDataHandler(importData);
                dataHandler.Execute();
            }
        }
    }
}
