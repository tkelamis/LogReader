using System;
using System.ComponentModel.DataAnnotations;

namespace LogReader
{
    public class LogData
    {
        [Key]
        public int LogId { get; set; }
        public DateTime dateTime { get; set; }
        public string errorType { get; set; }
        public string description { get; set; }
    }
}
