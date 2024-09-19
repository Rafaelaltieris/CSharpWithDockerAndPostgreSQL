using Microsoft.EntityFrameworkCore;

namespace DockerWithPostgreSql.Models.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }
    }
}
