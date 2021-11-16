using commercetools.Api.Models.Categories;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    [DeserializeAs(typeof(commercetools.Api.Models.Products.ProductAddToCategoryAction))]
    public partial interface IProductAddToCategoryAction : IProductUpdateAction
    {
        ICategoryResourceIdentifier Category { get; set;}
        
        string OrderHint { get; set;}
        
        bool? Staged { get; set;}
    }
}
