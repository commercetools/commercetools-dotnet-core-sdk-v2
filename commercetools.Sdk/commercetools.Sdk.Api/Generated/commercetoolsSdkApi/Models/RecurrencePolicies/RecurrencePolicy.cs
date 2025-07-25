using commercetools.Sdk.Api.Models.Common;
using System;

namespace commercetools.Sdk.Api.Models.RecurrencePolicies
{

    public partial class RecurrencePolicy : IRecurrencePolicy
    {
        public string Id { get; set; }

        public long Version { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime LastModifiedAt { get; set; }

        public string Key { get; set; }

        public ILocalizedString Name { get; set; }

        public ILocalizedString Description { get; set; }

        public IRecurrencePolicySchedule Schedule { get; set; }

        public ICreatedBy CreatedBy { get; set; }

        public ILastModifiedBy LastModifiedBy { get; set; }
    }
}
