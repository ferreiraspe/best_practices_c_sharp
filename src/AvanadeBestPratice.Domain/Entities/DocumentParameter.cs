﻿using Avanade.BestPractices.Infrastructure.Core.Entities;

namespace Avanade.BestPractices.Domain.Entities
{
    public class DocumentParameter : EntityBase
    {
        public Guid DocumentId { get; set; }
        public Document Document { get; set; }

        public string Key { get; set; }
        public string Value { get; set; }
    }
}
