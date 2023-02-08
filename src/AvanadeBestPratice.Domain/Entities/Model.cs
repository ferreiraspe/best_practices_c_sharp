using Avanade.BestPractices.Infrastructure.Core.Entities;

namespace Avanade.BestPractices.Domain.Entities
{
    public class Model : EntityBase
    {
        public Guid ManufacturerId { get; set; }
        public Manufacturer Manufacturer { get; set; }

        public string Name { get; set; }

        public List<ModelVersion> ModelVersions { get; set; }
    }
}
