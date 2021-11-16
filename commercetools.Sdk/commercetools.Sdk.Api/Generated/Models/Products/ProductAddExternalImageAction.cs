using commercetools.Api.Models.Common;


namespace commercetools.Api.Models.Products
{
    public partial class ProductAddExternalImageAction : IProductAddExternalImageAction
    {
        public string Action { get; set; }

        public long? VariantId { get; set; }

        public string Sku { get; set; }

        public IImage Image { get; set; }

        public bool? Staged { get; set; }
        public ProductAddExternalImageAction()
        {
            this.Action = "addExternalImage";
        }
    }
}
