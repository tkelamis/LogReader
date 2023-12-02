
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
            optionsBuilder.UseSqlServer(@"data source=DESKTOP-K7BBHPN\SQLEXPRESS; initial catalog=Log; TrustServerCertificate=True; integrated security=true");
        }
    }
}
