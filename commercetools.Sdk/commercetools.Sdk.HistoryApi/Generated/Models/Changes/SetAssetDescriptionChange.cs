using commercetools.HistoryApi.Models.ChangeValues;
using commercetools.HistoryApi.Models.Common;


namespace commercetools.HistoryApi.Models.Changes
{
    public partial class SetAssetDescriptionChange : ISetAssetDescriptionChange
    {
        public string Type { get; set;}
        
        public string Change { get; set;}
        
        public IAssetChangeValue Asset { get; set;}
        
        public ILocalizedString NextValue { get; set;}
        
        public ILocalizedString PreviousValue { get; set;}
        public SetAssetDescriptionChange()
        { 
           this.Type = "SetAssetDescriptionChange";
        }
    }
}
