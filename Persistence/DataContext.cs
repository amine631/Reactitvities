using domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Persistence
{
    public class DataContext: DbContext
    {
        public DataContext (DbContextOptions options): base(options)
        {

        }
        public DbSet<Activity> Activities{get;set;}
    }
}