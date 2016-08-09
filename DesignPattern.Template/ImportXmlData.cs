using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace DesignPattern.Template
{
    public class ImportXmlData : ImportData
    {
        private string data;

        public override string DataSourceName
        {
            get
            {
                return "XML";
            }
        }

        public override void InitDataSource()
        {
            data = "<Names><Name>Smith</Name><Name>John</Name><Name>Smith</Name><Name>James</Name><Name>Clara</Name><Name>James</Name></Names>";
        }

        public override List<string> GetNewData()
        {
            XDocument document = XDocument.Parse(data);
            return (from content in document.Descendants("Names").Descendants()
                    select content.Value).ToList();
        }
    }
}
