using GymManagement.Domain.Entities;
using GymManagement.Infrastructure.Contexts;

namespace GymManagement.Infrastructure.Repositories
{
    public class MemberRepository : RepositoryBase<Member>
    {
        public MemberRepository(GymManagementDbContext context) : base(context)
        {

        }
    }








}
