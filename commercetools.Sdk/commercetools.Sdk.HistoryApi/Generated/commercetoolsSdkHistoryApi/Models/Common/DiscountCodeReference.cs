

namespace commercetools.Sdk.HistoryApi.Models.Common
{

    public partial class DiscountCodeReference : IDiscountCodeReference
    {
        public IReferenceTypeId TypeId { get; set; }

        public string Id { get; set; }
        public DiscountCodeReference()
        {
            this.TypeId = IReferenceTypeId.FindEnum("discount-code");
        }
    }
}
