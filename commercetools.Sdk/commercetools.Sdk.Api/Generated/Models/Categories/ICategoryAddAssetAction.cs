using commercetools.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Categories
{
    [DeserializeAs(typeof(commercetools.Api.Models.Categories.CategoryAddAssetAction))]
    public partial interface ICategoryAddAssetAction : ICategoryUpdateAction
    {
        IAssetDraft Asset { get; set;}
        
        int? Position { get; set;}
    }
}
