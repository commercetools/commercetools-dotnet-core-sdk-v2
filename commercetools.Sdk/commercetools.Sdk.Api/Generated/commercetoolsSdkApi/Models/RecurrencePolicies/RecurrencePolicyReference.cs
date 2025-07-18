using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.RecurrencePolicies
{

    public partial class RecurrencePolicyReference : IRecurrencePolicyReference
    {
        public IReferenceTypeId TypeId { get; set; }

        public string Id { get; set; }

        public IRecurrencePolicy Obj { get; set; }
        public RecurrencePolicyReference()
        {
            this.TypeId = IReferenceTypeId.FindEnum("recurrence-policy");
        }
    }
}
