using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.CustomerGroups
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
