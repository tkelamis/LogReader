using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogReader
{
    public interface ILogReader
    {
        string GetThePathLogs();
        List<LogData> SetValues(string path=null);
        void ManipulateData(List<LogData> logList);
    }
}