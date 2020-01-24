using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreAjaxCrud.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> option) : base(option) { }
        public DbSet<Users> User { get; set; }
    }
}
