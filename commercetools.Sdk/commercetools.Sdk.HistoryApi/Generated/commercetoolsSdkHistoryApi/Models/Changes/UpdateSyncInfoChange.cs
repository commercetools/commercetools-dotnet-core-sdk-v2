using commercetools.Sdk.HistoryApi.Models.Common;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class UpdateSyncInfoChange : IUpdateSyncInfoChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public ISyncInfo NextValue { get; set; }

        public string ChannelId { get; set; }
        public UpdateSyncInfoChange()
        {
            this.Type = "UpdateSyncInfoChange";
        }
    }
}
