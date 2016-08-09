using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPattern.Template
{
    public abstract class ImportData
    {
        private readonly List<string> data = new List<string>();

        private List<string> newData;
        
        public void Execute()
        {
            InitDataSource();
            newData = GetNewData();
            AddNewData(newData);
            Display();
        }

        public abstract string DataSourceName { get; }
        public abstract void InitDataSource();
        public abstract List<string> GetNewData();

        private void AddNewData(IEnumerable<string> additionalData)
        {
            Console.WriteLine(string.Format("Importing data from a {0} data source", DataSourceName));

            foreach (string item in additionalData)
            {
                if(AlreadyInList(item))
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
