using InAndOut.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InAndOut.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {

        }
        // Items will be the table name in MS-SQL server DB
        public DbSet<Item> Items { get; set; }
        public DbSet<Expense> Expenses { get; set; }
    }
}
