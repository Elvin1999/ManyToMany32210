using ManyToMany32210.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManyToMany32210.DataAccess
{
    public class MyContext:DbContext
    {
        public MyContext()
        : base("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=MyTestDB;Integrated Security=True;")
        {
            
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
    }
}
