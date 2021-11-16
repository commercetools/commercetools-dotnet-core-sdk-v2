using commercetools.Api.Models.Common;


namespace commercetools.Api.Models.CustomerGroups
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
