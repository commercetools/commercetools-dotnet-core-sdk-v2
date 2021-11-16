using commercetools.HistoryApi.Models.Common;


namespace commercetools.HistoryApi.Models.Changes
{
    public partial class RemoveAssetChange : IRemoveAssetChange
    {
        public string Type { get; set;}
        
        public string Change { get; set;}
        
        public IAsset PreviousValue { get; set;}
        public RemoveAssetChange()
        { 
           this.Type = "RemoveAssetChange";
        }
    }
}
