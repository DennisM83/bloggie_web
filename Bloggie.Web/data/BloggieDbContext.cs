
using Microsoft.EntityFrameworkCore;

namespace Bloggie.Web.data
{
	public class BloggieDbContext : DbContext
	{
		public BloggieDbContext(DbContextOptions options) : base(options)
		{
		}
	}

}