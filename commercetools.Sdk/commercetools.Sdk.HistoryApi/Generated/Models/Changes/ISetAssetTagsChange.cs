using commercetools.HistoryApi.Models.ChangeValues;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Changes.SetAssetTagsChange))]
    public partial interface ISetAssetTagsChange : IChange
    {
        new string Change { get; set;}
        
        new string Type { get; set;}
        
        IAssetChangeValue Asset { get; set;}
        
        List<string> NextValue { get; set;}
        
        List<string> PreviousValue { get; set;}
    }
}
