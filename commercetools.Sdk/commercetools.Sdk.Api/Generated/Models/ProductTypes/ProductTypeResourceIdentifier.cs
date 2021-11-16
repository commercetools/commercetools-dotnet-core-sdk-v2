using commercetools.Api.Models.Common;


namespace commercetools.Api.Models.ProductTypes
{
    public partial class ProductTypeResourceIdentifier : IProductTypeResourceIdentifier
    {
        public IReferenceTypeId TypeId { get; set; }

        public string Id { get; set; }

        public string Key { get; set; }
        public ProductTypeResourceIdentifier()
        {
            this.TypeId = IReferenceTypeId.FindEnum("product-type");
        }
    }
}
