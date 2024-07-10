namespace commercetools.Sdk.Api.Models.ProductTailorings
{

    public partial class ProductTailoringRemoveImageAction : IProductTailoringRemoveImageAction
    {
        public string Action { get; set; }

        public long? VariantId { get; set; }

        public string Sku { get; set; }

        public string ImageUrl { get; set; }

        public bool? Staged { get; set; }
        public ProductTailoringRemoveImageAction()
        {
            this.Action = "removeImage";
        }
    }
}
