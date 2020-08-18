using Microsoft.EntityFrameworkCore;

namespace Group_C_06_SSAC.Data
{
    public class dataContext : DbContext
    {
        public dataContext(DbContextOptions<dataContext> options)
            : base(options)
        {
        }

        public DbSet<Group_C_06_SSAC.Models.Faculty> Faculty { get; set; }
       
        public DbSet<Group_C_06_SSAC.Models.Students> student { get; set; }
        public DbSet<Group_C_06_SSAC.Models.payment> Pay { get; set; }
        public DbSet<Group_C_06_SSAC.Models.salary> salary { get; set; }
       

    }
}
