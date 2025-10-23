

namespace commercetools.Sdk.HistoryApi.Models.Common
{

    public partial class CartDiscountReference : ICartDiscountReference
    {
        public IReferenceTypeId TypeId { get; set; }

        public string Id { get; set; }
        public CartDiscountReference()
        {
            this.TypeId = IReferenceTypeId.FindEnum("cart-discount");
        }
    }
}
