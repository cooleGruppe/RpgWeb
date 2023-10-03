using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class WebRpgContext : DbContext
	{
        public WebRpgContext(DbContextOptions<WebRpgContext> options) : base(options)
        {
        }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
		}
	}
}
