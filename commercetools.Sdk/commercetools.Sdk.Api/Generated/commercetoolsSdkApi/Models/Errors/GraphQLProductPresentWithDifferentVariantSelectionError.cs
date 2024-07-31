using commercetools.Sdk.Api.Models.ProductSelections;
using commercetools.Sdk.Api.Models.Products;

namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class GraphQLProductPresentWithDifferentVariantSelectionError : IGraphQLProductPresentWithDifferentVariantSelectionError
    {
        public string Code { get; set; }

        public IProductReference Product { get; set; }

        public IProductVariantSelection ExistingVariantSelection { get; set; }
        public GraphQLProductPresentWithDifferentVariantSelectionError()
        {
            this.Code = "ProductPresentWithDifferentVariantSelection";
        }
    }
}
