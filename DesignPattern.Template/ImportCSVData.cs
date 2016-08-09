using System.Collections.Generic;
using System.Linq;

namespace DesignPattern.Template
{
    class ImportCSVData : ImportData
    {
        private string data;

        public override string DataSourceName
        {
            get
            {
                return "CSV";
            }
        }

        public override void InitDataSource()
        {
            data = "John,Smith,John,Clara,James,Cook,Stella";
        }

        public override List<string> GetNewData()
        {
            return data.Split(',').ToList();
        }
    }
}
