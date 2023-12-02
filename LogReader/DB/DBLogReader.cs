using LogReader.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogReader.DB
{
    public class DBLogReader : ILogReader
    {
        private IMenu _menu = new Menu();

        public string GetThePathLogs()
        {
            return string.Empty;
        }

        public List<LogData> SetValues(string path)
        {
            List<string> list = new List<string>();
            using (StreamReader sr = new StreamReader(path))
            {
                while (sr.Peek() >= 0)
                {
                    list.Add(sr.ReadLine());
                }
            }
            List<LogData> logsList = new List<LogData>();
            int i = -1;
            foreach (var item in list)
            {
                i++;
                LogData log = new LogData();
                logsList.Add(log);
                log.dateTime = GetDateTime(i, list);
                log.errorType = GetErrorType(i, list);
                log.description = GetDescription(i, list);
            }


            using var context = new DataContext();
            context.Log.AddRange(logsList);
            context.SaveChanges();

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
