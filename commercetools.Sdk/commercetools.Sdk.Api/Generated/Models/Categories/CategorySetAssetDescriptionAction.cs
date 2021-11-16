using commercetools.Api.Models.Common;


namespace commercetools.Api.Models.Categories
{
    public partial class CategorySetAssetDescriptionAction : ICategorySetAssetDescriptionAction
    {
        public string Action { get; set;}
        
        public string AssetId { get; set;}
        
        public string AssetKey { get; set;}
        
        public ILocalizedString Description { get; set;}
        public CategorySetAssetDescriptionAction()
        { 
           this.Action = "setAssetDescription";
        }
    }
}
