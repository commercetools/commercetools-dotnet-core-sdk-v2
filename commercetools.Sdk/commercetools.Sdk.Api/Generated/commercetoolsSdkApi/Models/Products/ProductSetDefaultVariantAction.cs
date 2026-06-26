using commercetools.Sdk.Api.Models.Variants;


namespace commercetools.Sdk.Api.Models.Products
{

    public partial class ProductSetDefaultVariantAction : IProductSetDefaultVariantAction
    {
        public string Action { get; set; }

        public IVariantResourceIdentifier Variant { get; set; }

        public bool? Staged { get; set; }
        public ProductSetDefaultVariantAction()
        {
            this.Action = "setDefaultVariant";
        }
    }
}
