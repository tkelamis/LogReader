using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogReader
{
    public class TxtLogReader : ILogReader
    {
        private IMenu _menu = new Menu();

        public string GetThePathLogs()
        {
            var path = _menu.GiveMeThePath();
            var listOfFiles = _menu.GetListOfFilesFromDirectory(path);
            var pathOfFile = _menu.SelectFileToOpenAndGiveMeItsPath(listOfFiles);
            return pathOfFile;
        }
        public List<LogData> SetValues(string path)
        {
            List<string> lines = File.ReadAllLines(path).ToList();
            List<LogData> logsList = new List<LogData>();

            for (int i = 0; i < lines.Count; i++)
            {
                LogData log = new LogData
                {
                    DateTime = GetDateTime(i, lines),
                    ErrorType = GetErrorType(i, lines),
                    Description = GetDescription(i, lines)
                };

                logsList.Add(log);
            }
            return logsList;
        }

        public void ManipulateData(List<LogData> logList)
        {
            _menu.ChooseCategoryOfLogs(logList);
        }

        private DateTime GetDateTime(int i, List<string> list)
        {
            DateTime dateTime = Convert.ToDateTime(list[i].Substring(0, 19));
            return dateTime;
        }
        private string GetErrorType(int i, List<string> list)
        {
            string trimed_errorType = Convert.ToString(list[i].Remove(0, 22));
            string finalErrorType = trimed_errorType.Remove(trimed_errorType.LastIndexOf("-") - 1);
            return finalErrorType;
        }
        private string GetDescription(int i, List<string> list)
        {
            string description = Convert.ToString(list[i].Remove(0, list[i].LastIndexOf("-") + 2));
            return description;
        }
    }
}