using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRUDUsers.Models;

namespace CRUDUsers.DATA
{
 public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { } //required constructor

        public DbSet<User> Users { get; set; } //Dbset for users table (using CRuDUsers.models frame)


    }
}
