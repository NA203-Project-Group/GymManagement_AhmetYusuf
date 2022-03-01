using GymManagement.Domain.Entities;
using GymManagement.Infrastructure.Contexts;

namespace GymManagement.Infrastructure.Repositories
{
    public class WorkerContractRepository : RepositoryBase<WorkerContract>
    {
        public WorkerContractRepository(GymManagementDbContext context) : base(context)
        {

        }
    }








}
