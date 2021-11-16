using commercetools.HistoryApi.Models.ChangeValues;


namespace commercetools.HistoryApi.Models.Changes
{
    public partial class SetAssetKeyChange : ISetAssetKeyChange
    {
        public string Type { get; set;}
        
        public string Change { get; set;}
        
        public IAssetChangeValue Asset { get; set;}
        
        public string NextValue { get; set;}
        
        public string PreviousValue { get; set;}
        public SetAssetKeyChange()
        { 
           this.Type = "SetAssetKeyChange";
        }
    }
}
