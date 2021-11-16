using commercetools.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Changes.UpdateSyncInfoChange))]
    public partial interface IUpdateSyncInfoChange : IChange
    {
        new string Type { get; set;}
        
        new string Change { get; set;}
        
        string ChannelId { get; set;}
        
        ISyncInfo NextValue { get; set;}
    }
}
