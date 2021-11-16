using commercetools.Api.Models.Common;


namespace commercetools.Api.Models.Products
{
    public partial class ProductResourceIdentifier : IProductResourceIdentifier
    {
        public IReferenceTypeId TypeId { get; set; }

        public string Id { get; set; }

        public string Key { get; set; }
        public ProductResourceIdentifier()
        {
            this.TypeId = IReferenceTypeId.FindEnum("product");
        }
    }
}
