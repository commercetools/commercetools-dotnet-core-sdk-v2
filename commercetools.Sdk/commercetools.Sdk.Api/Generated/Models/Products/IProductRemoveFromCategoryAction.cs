using commercetools.Sdk.Api.Models.Categories;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Products
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Products.ProductRemoveFromCategoryAction))]
    public partial interface IProductRemoveFromCategoryAction : IProductUpdateAction
    {
        ICategoryResourceIdentifier Category { get; set; }

        bool? Staged { get; set; }

    }
}
