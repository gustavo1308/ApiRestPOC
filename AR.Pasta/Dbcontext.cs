using Microsoft.EntityFrameworkCore;

namespace AR.Pasta
{
    public class Dbcontext
    {
        private DbContextOptions options;

        public Dbcontext(DbContextOptions options)
        {
            this.options = options;
        }
    }
}