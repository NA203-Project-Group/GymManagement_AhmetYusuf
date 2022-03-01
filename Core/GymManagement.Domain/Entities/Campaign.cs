using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagement.Domain.Entities
{
    public class Campaign:BaseEntity
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public DateTime Duration { get; set; }
        public List<Member> Members { get; set; }

    }
}
