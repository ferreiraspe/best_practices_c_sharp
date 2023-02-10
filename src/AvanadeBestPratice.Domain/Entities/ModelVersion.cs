using Avanade.BestPractices.Infrastructure.Core.Entities;

namespace Avanade.BestPractices.Domain.Entities
{
    public class ModelVersion : EntityBase
    {
        public Guid ModelId { get; set; }
        public Model Model { get; set; }

        public string Name { get; set; }

        public List<Vehicle> Vehicles { get; set; }
    }
}
