using System.Collections.Generic;

namespace DesignPattern.Strategy
{
    public interface IImportData
    {
        string DataSourceName { get; }
        void InitDataSource();
        List<string> GetNewData();
    }
}