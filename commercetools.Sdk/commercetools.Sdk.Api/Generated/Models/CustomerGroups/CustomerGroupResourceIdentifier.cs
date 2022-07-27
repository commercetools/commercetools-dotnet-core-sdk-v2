using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.CustomerGroups
{

    public partial class CustomerGroupResourceIdentifier : ICustomerGroupResourceIdentifier
    {
        public IReferenceTypeId TypeId { get; set; }

        public string Id { get; set; }

        public string Key { get; set; }
        public CustomerGroupResourceIdentifier()
        {
            this.TypeId = IReferenceTypeId.FindEnum("customer-group");
        }
    }
}
