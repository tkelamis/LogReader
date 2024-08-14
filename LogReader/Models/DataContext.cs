
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogReader.Models
{
    public class DataContext:DbContext
    {
        public DbSet<LogData> Log { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-D6T0KON;Initial Catalog=LogsReader;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LogData>().HasData(
                new LogData { LogId = 1, DateTime = new DateTime(2023, 10, 11, 12, 34, 56), ErrorType = "INFO", Description = "User 'John' logged in." },
                new LogData { LogId = 2, DateTime = new DateTime(2023, 10, 11, 13, 45, 02), ErrorType = "ERROR", Description = "Database connection failed." },
                new LogData { LogId = 3, DateTime = new DateTime(2023, 10, 11, 14, 20, 30), ErrorType = "INFO", Description = "User 'Alice' logged in." },
                new LogData { LogId = 4, DateTime = new DateTime(2023, 10, 11, 15, 10, 15), ErrorType = "INFO", Description = "User 'Bob' logged in." },
                new LogData { LogId = 5, DateTime = new DateTime(2023, 10, 11, 15, 30, 45), ErrorType = "WARNING", Description = "Disk space is running low." },
                new LogData { LogId = 6, DateTime = new DateTime(2023, 10, 11, 16, 05, 12), ErrorType = "ERROR", Description = "Application crashed unexpectedly." },
                new LogData { LogId = 7, DateTime = new DateTime(2023, 10, 11, 16, 45, 22), ErrorType = "INFO", Description = "User 'Eve' logged in." },
                new LogData { LogId = 8, DateTime = new DateTime(2023, 10, 11, 17, 12, 55), ErrorType = "INFO", Description = "User 'Charlie' logged in." },
                new LogData { LogId = 9, DateTime = new DateTime(2023, 10, 11, 17, 25, 10), ErrorType = "WARNING", Description = "Server load is high." },
                new LogData { LogId = 10, DateTime = new DateTime(2023, 10, 11, 17, 55, 40), ErrorType = "ERROR", Description = "Out of memory error." },
                new LogData { LogId = 11, DateTime = new DateTime(2023, 10, 11, 18, 30, 01), ErrorType = "INFO", Description = "User 'David' logged in." },
                new LogData { LogId = 12, DateTime = new DateTime(2023, 10, 11, 18, 45, 25), ErrorType = "WARNING", Description = "Network connection lost." },
                new LogData { LogId = 13, DateTime = new DateTime(2023, 10, 11, 19, 15, 50), ErrorType = "INFO", Description = "User 'Frank' logged in." },
                new LogData { LogId = 14, DateTime = new DateTime(2023, 10, 11, 19, 30, 15), ErrorType = "WARNING", Description = "Unauthorized access attempt detected." },
                new LogData { LogId = 15, DateTime = new DateTime(2023, 10, 11, 20, 05, 33), ErrorType = "ERROR", Description = "File not found." },
                new LogData { LogId = 16, DateTime = new DateTime(2023, 10, 11, 20, 25, 49), ErrorType = "INFO", Description = "User 'Grace' logged in." },
                new LogData { LogId = 17, DateTime = new DateTime(2023, 10, 11, 20, 45, 10), ErrorType = "WARNING", Description = "Security breach detected." },
                new LogData { LogId = 18, DateTime = new DateTime(2023, 10, 11, 21, 15, 27), ErrorType = "ERROR", Description = "Server shutdown initiated." },
                new LogData { LogId = 19, DateTime = new DateTime(2023, 10, 11, 21, 35, 44), ErrorType = "INFO", Description = "User 'Hannah' logged in." },
                new LogData { LogId = 20, DateTime = new DateTime(2023, 10, 11, 21, 55, 59), ErrorType = "INFO", Description = "User 'Isabella' logged in." },
                new LogData { LogId = 21, DateTime = new DateTime(2023, 10, 11, 22, 30, 20), ErrorType = "WARNING", Description = "System update in progress." },
                new LogData { LogId = 22, DateTime = new DateTime(2023, 10, 11, 22, 55, 45), ErrorType = "ERROR", Description = "Data corruption detected." }
            );
        }
    }

    
}
