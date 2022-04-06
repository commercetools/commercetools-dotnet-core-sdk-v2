namespace commercetools.Sdk.ImportApi.Models.Common
{
    public partial class ProductDiscountKeyReference : IProductDiscountKeyReference
    {
        public string Key { get; set; }

        public IReferenceType TypeId { get; set; }
        public ProductDiscountKeyReference()
        {
            this.TypeId = IReferenceType.FindEnum("product-discount");
        }
    }
}
