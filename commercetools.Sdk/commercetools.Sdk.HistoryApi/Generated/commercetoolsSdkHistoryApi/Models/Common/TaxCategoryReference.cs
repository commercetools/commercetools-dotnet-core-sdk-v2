

namespace commercetools.Sdk.HistoryApi.Models.Common
{

    public partial class TaxCategoryReference : ITaxCategoryReference
    {
        public IReferenceTypeId TypeId { get; set; }

        public string Id { get; set; }
        public TaxCategoryReference()
        {
            this.TypeId = IReferenceTypeId.FindEnum("tax-category");
        }
    }
}
