using Microsoft.EntityFrameworkCore;

namespace ef_core_data.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<DbContext> options): base(options) 
        {
            
        }
    }
}
