using commercetools.Api.Models.Common;


namespace commercetools.Api.Models.CustomerGroups
{
    public partial class CustomerGroupReference : ICustomerGroupReference
    {
        public IReferenceTypeId TypeId { get; set; }

        public string Id { get; set; }

        public ICustomerGroup Obj { get; set; }
        public CustomerGroupReference()
        {
            this.TypeId = IReferenceTypeId.FindEnum("customer-group");
        }
    }
}
