using commercetools.Sdk.Api.Models.Categories;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Products
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Products.ProductAddToCategoryAction))]
    public partial interface IProductAddToCategoryAction : IProductUpdateAction
    {
        ICategoryResourceIdentifier Category { get; set; }

        string OrderHint { get; set; }

        bool? Staged { get; set; }
    }
}
