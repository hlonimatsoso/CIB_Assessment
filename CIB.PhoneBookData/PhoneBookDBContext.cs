using CIB.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace CIB.PhoneBookData
{
    public class PhoneBookDBContext : DbContext
    {
        private IConfiguration _config;

        public PhoneBookDBContext()
        {
        }
        //public PhoneBookDBContext(IConfiguration config)
        //{
        //    this._config = config;
        //}

        public PhoneBookDBContext(DbContextOptions<PhoneBookDBContext> options, IConfiguration config) : base(options)
        {
            this._config = config;

        }

        public DbSet<PhoneBook> PhoneBooks { get; set; }

        public DbSet<PhoneBookEntry> PhoneBookEntries { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer($"{_config.GetSection("ConnectionStrings:Default").Value}");
        }
    }
}
