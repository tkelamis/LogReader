using System;
using System.ComponentModel.DataAnnotations;

namespace LogReader
{
    public class LogData
    {
        [Key]
        public int LogId { get; set; }
        public DateTime DateTime { get; set; }
        public string ErrorType { get; set; }
        public string Description { get; set; }
    }
}
