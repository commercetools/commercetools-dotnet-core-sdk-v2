

namespace commercetools.Sdk.HistoryApi.Models.Common
{

    public partial class CustomerReference : ICustomerReference
    {
        public IReferenceTypeId TypeId { get; set; }

        public string Id { get; set; }
        public CustomerReference()
        {
            this.TypeId = IReferenceTypeId.FindEnum("customer");
        }
    }
}
