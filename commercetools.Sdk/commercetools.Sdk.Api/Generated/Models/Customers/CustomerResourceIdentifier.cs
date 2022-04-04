using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.Customers
{
    public partial class CustomerResourceIdentifier : ICustomerResourceIdentifier
    {
        public IReferenceTypeId TypeId { get; set; }

        public string Id { get; set; }

        public string Key { get; set; }
        public CustomerResourceIdentifier()
        {
            this.TypeId = IReferenceTypeId.FindEnum("customer");
        }
    }
}
