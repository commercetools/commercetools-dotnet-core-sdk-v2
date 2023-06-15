using commercetools.Sdk.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.UpdateSyncInfoChange))]
    public partial interface IUpdateSyncInfoChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        ISyncInfo NextValue { get; set; }

        string ChannelId { get; set; }

    }
}
