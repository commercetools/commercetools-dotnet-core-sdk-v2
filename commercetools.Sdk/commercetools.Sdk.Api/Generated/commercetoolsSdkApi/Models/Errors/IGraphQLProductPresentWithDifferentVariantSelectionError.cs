using commercetools.Sdk.Api.Models.ProductSelections;
using commercetools.Sdk.Api.Models.Products;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.GraphQLProductPresentWithDifferentVariantSelectionError))]
    public partial interface IGraphQLProductPresentWithDifferentVariantSelectionError : IGraphQLErrorObject
    {
        new string Code { get; set; }

        IProductReference Product { get; set; }

        IProductVariantSelection ExistingVariantSelection { get; set; }

    }
}
