using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.Customers
{

    public partial class CustomerEmailTokenReference : ICustomerEmailTokenReference
    {
        public IReferenceTypeId TypeId { get; set; }

        public string Id { get; set; }
        public CustomerEmailTokenReference()
        {
            this.TypeId = IReferenceTypeId.FindEnum("customer-email-token");
        }
    }
}
