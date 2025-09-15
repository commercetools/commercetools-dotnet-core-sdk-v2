using commercetools.Sdk.CheckoutApi.Models.Common;


namespace commercetools.Sdk.CheckoutApi.Models.Applications
{

    public partial class ApplicationResourceIdentifier : IApplicationResourceIdentifier
    {
        public IReferenceTypeId TypeId { get; set; }

        public string Id { get; set; }

        public string Key { get; set; }
        public ApplicationResourceIdentifier()
        {
            this.TypeId = IReferenceTypeId.FindEnum("application");
        }
    }
}
