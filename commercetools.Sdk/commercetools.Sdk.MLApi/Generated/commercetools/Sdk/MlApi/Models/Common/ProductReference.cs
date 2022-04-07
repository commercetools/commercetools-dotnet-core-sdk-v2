namespace commercetools.Sdk.MLApi.Models.Common
{
    public partial class ProductReference : IProductReference
    {
        public IReferenceTypeId TypeId { get; set; }

        public string Id { get; set; }
        public ProductReference()
        {
            this.TypeId = IReferenceTypeId.FindEnum("product");
        }
    }
}
