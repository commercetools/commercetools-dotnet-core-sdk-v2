using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Categories
{
    [DeserializeAs(typeof(commercetools.Api.Models.Categories.CategorySetAssetCustomFieldAction))]
    public partial interface ICategorySetAssetCustomFieldAction : ICategoryUpdateAction
    {
        string AssetId { get; set;}
        
        string AssetKey { get; set;}
        
        string Name { get; set;}
        
        Object Value { get; set;}
    }
}
