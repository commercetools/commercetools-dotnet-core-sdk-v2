namespace commercetools.Sdk.Api.Models.ProductTailorings
{

    public partial class ProductTailoringRemoveVariantAction : IProductTailoringRemoveVariantAction
    {
        public string Action { get; set; }

        public long? Id { get; set; }

        public string Sku { get; set; }

        public bool? Staged { get; set; }
        public ProductTailoringRemoveVariantAction()
        {
            this.Action = "removeVariant";
        }
    }
}
