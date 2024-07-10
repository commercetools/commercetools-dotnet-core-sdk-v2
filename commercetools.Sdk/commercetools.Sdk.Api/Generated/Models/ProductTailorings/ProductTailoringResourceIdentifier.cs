using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.ProductTailorings
{

    public partial class ProductTailoringResourceIdentifier : IProductTailoringResourceIdentifier
    {
        public IReferenceTypeId TypeId { get; set; }

        public string Id { get; set; }

        public string Key { get; set; }
        public ProductTailoringResourceIdentifier()
        {
            this.TypeId = IReferenceTypeId.FindEnum("product-tailoring");
        }
    }
}
