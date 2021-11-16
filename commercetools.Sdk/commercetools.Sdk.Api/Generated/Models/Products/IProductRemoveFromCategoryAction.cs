using commercetools.Api.Models.Categories;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    [DeserializeAs(typeof(commercetools.Api.Models.Products.ProductRemoveFromCategoryAction))]
    public partial interface IProductRemoveFromCategoryAction : IProductUpdateAction
    {
        ICategoryResourceIdentifier Category { get; set; }

        bool? Staged { get; set; }
    }
}
