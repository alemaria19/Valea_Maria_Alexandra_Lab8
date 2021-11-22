using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Valea_Maria_Alexandra_Lab8.Models;

namespace Valea_Maria_Alexandra_Lab8.Data
{
    public class Valea_Maria_Alexandra_Lab8Context : DbContext
    {
        public Valea_Maria_Alexandra_Lab8Context (DbContextOptions<Valea_Maria_Alexandra_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Valea_Maria_Alexandra_Lab8.Models.Book> Book { get; set; }

        public DbSet<Valea_Maria_Alexandra_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Valea_Maria_Alexandra_Lab8.Models.Category> Category { get; set; }
    }
}
