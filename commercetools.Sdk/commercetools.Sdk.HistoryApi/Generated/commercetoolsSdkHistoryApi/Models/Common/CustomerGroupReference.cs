

namespace commercetools.Sdk.HistoryApi.Models.Common
{

    public partial class CustomerGroupReference : ICustomerGroupReference
    {
        public IReferenceTypeId TypeId { get; set; }

        public string Id { get; set; }
        public CustomerGroupReference()
        {
            this.TypeId = IReferenceTypeId.FindEnum("customer-group");
        }
    }
}
