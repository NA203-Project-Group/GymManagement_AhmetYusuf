using GymManagement.Domain.Entities;
using GymManagement.Infrastructure.Contexts;

namespace GymManagement.Infrastructure.Repositories
{
    public class TrainerRepository : RepositoryBase<Trainer>
    {
        public TrainerRepository(GymManagementDbContext context) : base(context)
        {

        }
    }








}
