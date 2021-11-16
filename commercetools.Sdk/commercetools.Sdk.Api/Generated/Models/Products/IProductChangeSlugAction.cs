using commercetools.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    [DeserializeAs(typeof(commercetools.Api.Models.Products.ProductChangeSlugAction))]
    public partial interface IProductChangeSlugAction : IProductUpdateAction
    {
        ILocalizedString Slug { get; set;}
        
        bool? Staged { get; set;}
    }
}
