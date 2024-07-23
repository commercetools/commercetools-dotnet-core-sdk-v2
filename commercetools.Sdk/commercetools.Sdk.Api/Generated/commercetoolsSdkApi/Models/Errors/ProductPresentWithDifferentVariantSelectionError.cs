using commercetools.Sdk.Api.Models.ProductSelections;
using commercetools.Sdk.Api.Models.Products;


namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class ProductPresentWithDifferentVariantSelectionError : IProductPresentWithDifferentVariantSelectionError
    {
        public string Code { get; set; }

        public string Message { get; set; }

        public IProductReference Product { get; set; }

        public IProductVariantSelection ExistingVariantSelection { get; set; }
        public ProductPresentWithDifferentVariantSelectionError()
        {
            this.Code = "ProductPresentWithDifferentVariantSelection";
        }
    }
}
