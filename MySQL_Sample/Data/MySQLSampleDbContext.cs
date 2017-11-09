using Microsoft.EntityFrameworkCore;
using MySQL_Sample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MySQL_Sample.Data
{
    public class MySQLSampleDbContext: DbContext
    {
        public DbSet<MyTest> MyTests { get; set; }

        public MySQLSampleDbContext(DbContextOptions<MySQLSampleDbContext> options): base(options)
        {
        }
    }
}
