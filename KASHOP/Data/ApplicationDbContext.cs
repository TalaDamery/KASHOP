using Microsoft.EntityFrameworkCore;

namespace KASHOP.Data
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            //database for development
            //optionsBuilder.UseSqlServer("Data Source=.;Database=KASHOP;Integrated Security=True;Connect Timeout=30;Encrypt=True;TrustServerCertificate=True;Command Timeout=30");

            //database for production
            optionsBuilder.UseSqlServer("Server=db38655.public.databaseasp.net; Database=db38655; User Id=db38655; Password=A_k7y4#XKo8+; Encrypt=True; TrustServerCertificate=True; MultipleActiveResultSets=True; ");
        }
    }
}
