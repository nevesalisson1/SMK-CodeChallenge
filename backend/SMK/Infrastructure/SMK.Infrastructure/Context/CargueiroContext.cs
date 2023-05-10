using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SMK.Infrastructure.Entities;

namespace SMK.Infrastructure.Context
{
    public class CargueiroContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public CargueiroContext()
        {

        }

        public CargueiroContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to sqlite database
            options.UseSqlite(Configuration.GetConnectionString("DefaultConnection"));
        }

        public DbSet<Cargueiro> Cargueiros { get; set; }

    }
}
