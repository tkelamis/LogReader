using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace LogReader
{
    public class XmlLogReader : ILogReader
    {
        private IMenu _menu = new Menu();
        public string GetThePathLogs()
        {
            var path = _menu.GiveMeThePath();
            var listOfFiles = _menu.GetListOfFilesFromDirectory(path);
            var pathOfFile = _menu.SelectFileToOpenAndGiveMeItsPath(listOfFiles);
            return pathOfFile;
        }

        public List<LogData> SetValues(string pathOfXmlFiles)
        {
            List<Entry> list = new List<Entry>();
            XmlSerializer serializer = new XmlSerializer(typeof(Log));
            Log logs;
            using (FileStream reader = new FileStream(pathOfXmlFiles, FileMode.Open))
            {
                logs = (Log)serializer.Deserialize(reader);
                foreach (var item in logs.Entry)
                {
                    list.Add(item);
                }
            }

            List<LogData> logDataList = new List<LogData>();

            foreach (var item in list)
            {
                LogData logItem = new LogData();
                logItem.DateTime = DateTime.Parse(item.dateTime);
                logItem.ErrorType = item.errorType;
                logItem.Description = item.description;
                logDataList.Add(logItem);
            }
            return logDataList;
        }

        public void ManipulateData(List<LogData> logList)
        {
            _menu.ChooseCategoryOfLogs(logList);
        }
    }
}