using System;

namespace GymManagement.Domain.Entities
{
    public class Equipment:BaseEntity
    {
        public string Name { get; set; }
        public DateTime MaintenancePeriod { get; set; }
        public byte Duraiton { get; set; }
        public bool IsActive { get; set; }
        public int TrainerId { get; set; }
        public Trainer Trainer { get; set; }

    }

}
