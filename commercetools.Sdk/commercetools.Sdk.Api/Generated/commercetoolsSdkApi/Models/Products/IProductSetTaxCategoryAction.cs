using commercetools.Sdk.Api.Models.TaxCategories;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Products
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Products.ProductSetTaxCategoryAction))]
    public partial interface IProductSetTaxCategoryAction : IProductUpdateAction
    {
        ITaxCategoryResourceIdentifier TaxCategory { get; set; }

    }
}
