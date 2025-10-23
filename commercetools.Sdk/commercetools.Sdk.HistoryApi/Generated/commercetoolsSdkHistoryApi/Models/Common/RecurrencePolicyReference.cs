

namespace commercetools.Sdk.HistoryApi.Models.Common
{

    public partial class RecurrencePolicyReference : IRecurrencePolicyReference
    {
        public IReferenceTypeId TypeId { get; set; }

        public string Id { get; set; }
        public RecurrencePolicyReference()
        {
            this.TypeId = IReferenceTypeId.FindEnum("recurrence-policy");
        }
    }
}
