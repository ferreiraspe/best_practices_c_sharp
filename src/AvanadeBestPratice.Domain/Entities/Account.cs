using Avanade.BestPractices.Infrastructure.Core.Entities;
using Avanade.BestPractices.Infrastructure.Core.Entities.Interfaces;

namespace Avanade.BestPractices.Domain.Entities
{
    public class Account : EntityBase
    {
        public string Name { get; set; }
        public DateTime DateOfBirthday { get; set; }
        public bool IsApproved { get; set; }

        public List<Document> Documents { get; set; }
        public List<Ride> Rides { get; set; }
    }
}
