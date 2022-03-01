using GymManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagement.Infrastructure.Contexts
{
    public class GymManagementDbContext:DbContext
    {
        public GymManagementDbContext(DbContextOptions<GymManagementDbContext>options):base(options)
        {

        }

        public DbSet<Worker>Workers { get; set; }
    }
}
