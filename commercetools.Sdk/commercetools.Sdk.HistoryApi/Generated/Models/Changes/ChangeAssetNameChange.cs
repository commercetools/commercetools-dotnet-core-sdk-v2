using commercetools.HistoryApi.Models.ChangeValues;
using commercetools.HistoryApi.Models.Common;


namespace commercetools.HistoryApi.Models.Changes
{
    public partial class ChangeAssetNameChange : IChangeAssetNameChange
    {
        public string Type { get; set;}
        
        public string Change { get; set;}
        
        public IAssetChangeValue Asset { get; set;}
        
        public ILocalizedString NextValue { get; set;}
        
        public ILocalizedString PreviousValue { get; set;}
        public ChangeAssetNameChange()
        { 
           this.Type = "ChangeAssetNameChange";
        }
    }
}
