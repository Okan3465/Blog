﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogApiDemo.DataAccessLayer
{
    public class Context :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=LAPTOP-1109MN6F\\SQLEXPRESS;database=CoreBlogApiDb;integrated security=true;");

            //veritabanı bağlantılarıı sağlandı 
        }
        public DbSet<Employee> Employees { get; set; }
    }
}
