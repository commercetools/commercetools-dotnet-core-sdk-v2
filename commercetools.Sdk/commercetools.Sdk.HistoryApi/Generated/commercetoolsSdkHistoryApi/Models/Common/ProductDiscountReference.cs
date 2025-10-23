

namespace commercetools.Sdk.HistoryApi.Models.Common
{

    public partial class ProductDiscountReference : IProductDiscountReference
    {
        public IReferenceTypeId TypeId { get; set; }

        public string Id { get; set; }
        public ProductDiscountReference()
        {
            this.TypeId = IReferenceTypeId.FindEnum("product-discount");
        }
    }
}
