

namespace commercetools.Sdk.HistoryApi.Models.Common
{

    public partial class ProductSelectionReference : IProductSelectionReference
    {
        public IReferenceTypeId TypeId { get; set; }

        public string Id { get; set; }
        public ProductSelectionReference()
        {
            this.TypeId = IReferenceTypeId.FindEnum("product-selection");
        }
    }
}
