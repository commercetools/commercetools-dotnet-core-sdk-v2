using commercetools.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    [DeserializeAs(typeof(commercetools.Api.Models.Products.ProductSetDescriptionAction))]
    public partial interface IProductSetDescriptionAction : IProductUpdateAction
    {
        ILocalizedString Description { get; set;}
        
        bool? Staged { get; set;}
    }
}
