using System;

using AR.Domain;

using Microsoft.EntityFrameworkCore;

namespace AR.Pasta
{
    public class ContextoPrincipal : Dbcontext

    {
        public ContextoPrincipal(DbContextOptions options) 
            : base()
        {
        }

        public DbSet<Cliente>
    }
}
