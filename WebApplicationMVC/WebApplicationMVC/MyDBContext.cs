

using Microsoft.EntityFrameworkCore;
using WebApplicationMVC.Models;

namespace WebApplicationMVC
{
    public class MyDBContext: DbContext
    {
        public MyDBContext(DbContextOptions options):base(options){

        }

        public DbSet<Student> Students{get; set;}

    }
}