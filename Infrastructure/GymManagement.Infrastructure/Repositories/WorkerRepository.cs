using GymManagement.Domain.Entities;
using GymManagement.Infrastructure.Contexts;

namespace GymManagement.Infrastructure.Repositories
{
    public class WorkerRepository : RepositoryBase<Worker>
    {
        public WorkerRepository(GymManagementDbContext context) : base(context)
        {

        }
    }








}
