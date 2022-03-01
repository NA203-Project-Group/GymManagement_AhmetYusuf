using GymManagement.Domain.Entities;
using GymManagement.Infrastructure.Contexts;

namespace GymManagement.Infrastructure.Repositories
{
    public class ManagerRepository : RepositoryBase<Manager>
    {
        public ManagerRepository(GymManagementDbContext context) : base(context)
        {

        }
    }








}
