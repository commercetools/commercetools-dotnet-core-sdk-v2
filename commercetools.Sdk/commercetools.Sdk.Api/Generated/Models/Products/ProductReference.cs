using commercetools.Api.Models.Common;


namespace commercetools.Api.Models.Products
{
    public partial class ProductReference : IProductReference
    {
        public IReferenceTypeId TypeId { get; set; }

        public string Id { get; set; }

        public IProduct Obj { get; set; }
        public ProductReference()
        {
            this.TypeId = IReferenceTypeId.FindEnum("product");
        }
    }
}
