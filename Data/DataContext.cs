using Microsoft.EntityFrameworkCore;
using Siemensblazorserverapp.Models;

namespace Siemensblazorserverapp.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options)
        {
                
        }

        public DbSet<Person> tablepersons { get; set; }
    }
}
