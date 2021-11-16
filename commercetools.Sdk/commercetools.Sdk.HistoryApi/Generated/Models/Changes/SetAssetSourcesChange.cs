using commercetools.HistoryApi.Models.ChangeValues;
using commercetools.HistoryApi.Models.Common;
using System.Collections.Generic;


namespace commercetools.HistoryApi.Models.Changes
{
    public partial class SetAssetSourcesChange : ISetAssetSourcesChange
    {
        public string Type { get; set;}
        
        public string Change { get; set;}
        
        public IAssetChangeValue Asset { get; set;}
        
        public List<IAssetSource> NextValue { get; set;}
        
        public List<IAssetSource> PreviousValue { get; set;}
        public SetAssetSourcesChange()
        { 
           this.Type = "SetAssetSourcesChange";
        }
    }
}
