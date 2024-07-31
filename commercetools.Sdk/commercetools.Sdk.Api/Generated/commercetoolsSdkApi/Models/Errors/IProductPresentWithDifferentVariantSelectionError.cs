using commercetools.Sdk.Api.Models.ProductSelections;
using commercetools.Sdk.Api.Models.Products;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.ProductPresentWithDifferentVariantSelectionError))]
    public partial interface IProductPresentWithDifferentVariantSelectionError : IErrorObject
    {
        new string Code { get; set; }

        new string Message { get; set; }

        IProductReference Product { get; set; }

        IProductVariantSelection ExistingVariantSelection { get; set; }

    }
}
