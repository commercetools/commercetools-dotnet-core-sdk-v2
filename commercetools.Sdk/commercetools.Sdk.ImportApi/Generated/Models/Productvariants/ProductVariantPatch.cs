using commercetools.Sdk.ImportApi.Models.Common;


namespace commercetools.Sdk.ImportApi.Models.Productvariants
{
    public partial class ProductVariantPatch : IProductVariantPatch
    {
        public IProductVariantKeyReference ProductVariant { get; set; }

        public IAttributes Attributes { get; set; }

        public bool? Staged { get; set; }
    }
}
