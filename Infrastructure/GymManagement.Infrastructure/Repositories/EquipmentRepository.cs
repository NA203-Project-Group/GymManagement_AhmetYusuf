using GymManagement.Domain.Entities;
using GymManagement.Infrastructure.Contexts;

namespace GymManagement.Infrastructure.Repositories
{
    public class EquipmentRepository : RepositoryBase<Equipment>
    {
        public EquipmentRepository(GymManagementDbContext context) : base(context)
        {

        }
    }








}
