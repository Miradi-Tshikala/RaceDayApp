using Microsoft.EntityFrameworkCore;

namespace RaceDayAPI.Data
{
    public class RaceDayDBContext:DbContext
    {
        public RaceDayDBContext(DbContextOptions options):base (options) {
        
                
        }
    }
}
