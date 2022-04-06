namespace commercetools.Sdk.ImportApi.Models.Common
{
    public partial class ProductVariantKeyReference : IProductVariantKeyReference
    {
        public string Key { get; set; }

        public IReferenceType TypeId { get; set; }
        public ProductVariantKeyReference()
        {
            this.TypeId = IReferenceType.FindEnum("product-variant");
        }
    }
}
