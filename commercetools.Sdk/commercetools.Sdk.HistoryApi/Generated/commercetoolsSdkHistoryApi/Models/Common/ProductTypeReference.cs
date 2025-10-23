

namespace commercetools.Sdk.HistoryApi.Models.Common
{

    public partial class ProductTypeReference : IProductTypeReference
    {
        public IReferenceTypeId TypeId { get; set; }

        public string Id { get; set; }
        public ProductTypeReference()
        {
            this.TypeId = IReferenceTypeId.FindEnum("product-type");
        }
    }
}
