using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPattern.Strategy
{
    public class ImportDataHandler
    {
        private readonly List<string> data = new List<string>();
        private List<string> newData;
        private readonly IImportData importData;

        public ImportDataHandler(IImportData importData)
        {
            this.importData = importData;    
        }

        public void Execute()
        {
            importData.InitDataSource();
            newData = importData.GetNewData();
            AddNewData(newData);
            Display();
        }

        private void AddNewData(IEnumerable<string> additionalData)
        {
            Console.WriteLine(string.Format("Importing data from a {0} data source", importData.DataSourceName));

            foreach (string item in additionalData)
            {
                if (AlreadyInList(item))
                {
                    continue;
                }

                data.Add(item);
            }
        }

        private void Display()
        {
            foreach (string item in data)
            {
                Console.WriteLine(item);
            }
        }

        private bool AlreadyInList(string item)
        {
            int count = data.Where(d => d.Equals(item, StringComparison.InvariantCultureIgnoreCase)).Count();
            return count > 0;
        }
    }
}