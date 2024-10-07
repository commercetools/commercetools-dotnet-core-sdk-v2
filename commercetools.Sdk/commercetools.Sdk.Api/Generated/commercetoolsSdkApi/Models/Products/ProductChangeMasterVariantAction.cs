

namespace commercetools.Sdk.Api.Models.Products
{

    public partial class ProductChangeMasterVariantAction : IProductChangeMasterVariantAction
    {
        public string Action { get; set; }

        public long? VariantId { get; set; }

        public string Sku { get; set; }

        public bool? Staged { get; set; }
        public ProductChangeMasterVariantAction()
        {
            this.Action = "changeMasterVariant";
        }
    }
}
