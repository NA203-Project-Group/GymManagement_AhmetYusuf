using GymManagement.Application.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagement.Infrastructure.UnitOfWorks
{
    public class UnitOfWork
    {
        public ICampaignRepository Campaigns { get; }
        public IEmployeeDetailRepository EmployeeDetails { get; }
        public IEquipmentRepository Equipments { get; }
        public IExerciseProgramRepository ExercisePrograms { get; }
        public IManagerRepository Managers { get; }
        public IMemberRepository Members { get; }
        public IMissionRepository Missions { get; }
        public ITrainerRepository Trainers { get; }
        public IWorkerContractRepository WorkerContracts { get; }
        public IWorkerRepository Workers { get; }

        public UnitOfWork(ICampaignRepository campaigns, IEmployeeDetailRepository employeeDetails,
            IEquipmentRepository equipments, IExerciseProgramRepository exercisePrograms,
            IManagerRepository managers, IMemberRepository members, IMissionRepository missions,
            ITrainerRepository trainers, IWorkerContractRepository workerContracts, IWorkerRepository workers)
        {
            Campaigns = campaigns;
            EmployeeDetails = employeeDetails;
            Equipments = equipments;
            ExercisePrograms = exercisePrograms;
            Managers = managers;
            Members = members;
            Missions = missions;
            Trainers = trainers;
            WorkerContracts = workerContracts;
            Workers = workers;
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }


    }
}
