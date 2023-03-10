using Avanade.BestPractices.Domain.Entities.Enums;
using Avanade.BestPractices.Domain.ValueObjects;
using Avanade.BestPractices.Infrastructure.Core.Entities;

namespace Avanade.BestPractices.Domain.Entities
{
    public class Charge : EntityBase
    {
        public Guid RideId { get; set; }
        public Ride Ride { get; set; }

        public Money GrossValue { get; set; }
        public Money DiscountValue { get; set; }
        public Money NetValue { get; set; }
        public ChargeStatus Status { get; set; }
        public string Description { get; set; }
    }
}
