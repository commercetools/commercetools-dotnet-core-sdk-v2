using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.RecurrencePolicies;
using System;

namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class RecurringOrderScheduleSetMessage : IRecurringOrderScheduleSetMessage
    {
        public string Id { get; set; }

        public long Version { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime LastModifiedAt { get; set; }

        public ILastModifiedBy LastModifiedBy { get; set; }

        public ICreatedBy CreatedBy { get; set; }

        public long SequenceNumber { get; set; }

        public IReference Resource { get; set; }

        public long ResourceVersion { get; set; }

        public string Type { get; set; }

        public IUserProvidedIdentifiers ResourceUserProvidedIdentifiers { get; set; }

        public IRecurrencePolicySchedule RecurrencePolicySchedule { get; set; }

        public IRecurrencePolicySchedule OldRecurrencePolicySchedule { get; set; }
        public RecurringOrderScheduleSetMessage()
        {
            this.Type = "RecurringOrderScheduleSet";
        }
    }
}
