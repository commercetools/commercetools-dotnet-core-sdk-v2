using commercetools.Sdk.CheckoutApi.Models.Common;


namespace commercetools.Sdk.CheckoutApi.Models.Applications
{

    public partial class ApplicationReference : IApplicationReference
    {
        public IReferenceTypeId TypeId { get; set; }

        public string Id { get; set; }
        public ApplicationReference()
        {
            this.TypeId = IReferenceTypeId.FindEnum("application");
        }
    }
}
