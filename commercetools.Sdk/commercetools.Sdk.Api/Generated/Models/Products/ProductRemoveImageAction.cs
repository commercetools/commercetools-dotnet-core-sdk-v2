namespace commercetools.Sdk.Api.Models.Products
{
    public partial class ProductRemoveImageAction : IProductRemoveImageAction
    {
        public string Action { get; set; }

        public long? VariantId { get; set; }

        public string Sku { get; set; }

        public string ImageUrl { get; set; }

        public bool? Staged { get; set; }
        public ProductRemoveImageAction()
        {
            this.Action = "removeImage";
        }
    }
}
