namespace commercetools.Sdk.ImportApi.Models.Common
{
    public partial class ProductTypeKeyReference : IProductTypeKeyReference
    {
        public string Key { get; set; }

        public IReferenceType TypeId { get; set; }
        public ProductTypeKeyReference()
        {
            this.TypeId = IReferenceType.FindEnum("product-type");
        }
    }
}
