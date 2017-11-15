using GreenfoxQuizApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreenfoxQuizApp.Entities
{
    public class GreenfoxQuizAppContext : DbContext
    {
        public GreenfoxQuizAppContext(DbContextOptions<GreenfoxQuizAppContext> options) : base(options)
        {
        }

        public DbSet<Text> Texts { get; set; }
    }
}
