using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.RecurrencePolicies
{

    public partial class RecurrencePolicyResourceIdentifier : IRecurrencePolicyResourceIdentifier
    {
        public IReferenceTypeId TypeId { get; set; }

        public string Id { get; set; }

        public string Key { get; set; }
        public RecurrencePolicyResourceIdentifier()
        {
            this.TypeId = IReferenceTypeId.FindEnum("recurrence-policy");
        }
    }
}
