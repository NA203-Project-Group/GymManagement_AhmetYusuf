using GymManagement.Domain.Entities;
using GymManagement.Infrastructure.Contexts;

namespace GymManagement.Infrastructure.Repositories
{
    public class MissionRepository : RepositoryBase<Mission>
    {
        public MissionRepository(GymManagementDbContext context) : base(context)
        {

        }
    }








}
