using commercetools.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    [DeserializeAs(typeof(commercetools.Api.Models.Products.ProductChangeNameAction))]
    public partial interface IProductChangeNameAction : IProductUpdateAction
    {
        ILocalizedString Name { get; set;}
        
        bool? Staged { get; set;}
    }
}
