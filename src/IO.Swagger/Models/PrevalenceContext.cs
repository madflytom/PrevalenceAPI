using Microsoft.EntityFrameworkCore;

namespace IO.Swagger.Models
{ 
    public class PrevalenceContext : DbContext
    {
        public PrevalenceContext(DbContextOptions<PrevalenceContext> options)
            : base(options)
        { }

        public DbSet<Prevalence> Prevalence { get; set; }
    }
}