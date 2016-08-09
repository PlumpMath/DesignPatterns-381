using System.Collections.Generic;
using System.Linq;

namespace DesignPattern.Strategy
{
    class ImportCSVData : IImportData
    {
        private string data;

        public string DataSourceName
        {
            get
            {
                return "CSV";
            }
        }

        public void InitDataSource()
        {
            data = "John,Smith,John,Clara,James,Cook,Stella";
        }

        public List<string> GetNewData()
        {
            return data.Split(',').ToList();
        }
    }
}