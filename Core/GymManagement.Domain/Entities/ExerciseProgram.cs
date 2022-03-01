using System;
using System.Collections.Generic;

namespace GymManagement.Domain.Entities
{
    public class ExerciseProgram : BaseEntity
    {
        public string Name { get; set; }
        public DateTime Duration { get; set; }

        public List<Member> Members;
        public int TrainerId { get; set; }
        public Trainer Trainer { get; set; }

    }
}
