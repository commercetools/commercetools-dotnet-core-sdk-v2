namespace commercetools.Sdk.Api.Models.Products
{

    public partial class ProductRemoveVariantAction : IProductRemoveVariantAction
    {
        public string Action { get; set; }

        public long? Id { get; set; }

        public string Sku { get; set; }

        public bool? Staged { get; set; }
        public ProductRemoveVariantAction()
        {
            this.Action = "removeVariant";
        }
    }
}
