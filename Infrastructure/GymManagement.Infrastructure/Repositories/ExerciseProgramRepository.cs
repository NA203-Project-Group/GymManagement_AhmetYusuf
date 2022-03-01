using GymManagement.Domain.Entities;
using GymManagement.Infrastructure.Contexts;

namespace GymManagement.Infrastructure.Repositories
{
    public class ExerciseProgramRepository : RepositoryBase<ExerciseProgram>
    {
        public ExerciseProgramRepository(GymManagementDbContext context) : base(context)
        {

        }
    }








}
