using Microsoft.EntityFrameworkCore;

namespace NetCoreMVC.Models
{
    public class NetCoreMVCContext : DbContext
    {
        public NetCoreMVCContext (DbContextOptions<NetCoreMVCContext> options)
            : base(options)
        {
        }
        public DbSet<NetCoreMVC.Models.Product> Product { get; set; }
    }
}
