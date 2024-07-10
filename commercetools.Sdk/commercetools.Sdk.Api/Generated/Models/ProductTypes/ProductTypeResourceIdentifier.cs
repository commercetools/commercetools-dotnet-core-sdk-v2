using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.ProductTypes
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
