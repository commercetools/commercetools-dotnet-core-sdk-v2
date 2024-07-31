using commercetools.Sdk.Api.Models.Products;

namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class ProductAssignmentMissingError : IProductAssignmentMissingError
    {
        public string Code { get; set; }

        public string Message { get; set; }

        public IProductReference Product { get; set; }
        public ProductAssignmentMissingError()
        {
            this.Code = "ProductAssignmentMissing";
        }
    }
}
