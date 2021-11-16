namespace commercetools.HistoryApi.Models.Common
{
    public partial class SyncInfo : ISyncInfo
    {
        public IReference Channel { get; set; }

        public string ExternalId { get; set; }

        public string SyncedAt { get; set; }
    }
}
