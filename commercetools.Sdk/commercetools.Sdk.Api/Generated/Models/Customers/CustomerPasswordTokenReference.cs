using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.Customers
{

    public partial class CustomerPasswordTokenReference : ICustomerPasswordTokenReference
    {
        public IReferenceTypeId TypeId { get; set; }

        public string Id { get; set; }
        public CustomerPasswordTokenReference()
        {
            this.TypeId = IReferenceTypeId.FindEnum("customer-password-token");
        }
    }
}
