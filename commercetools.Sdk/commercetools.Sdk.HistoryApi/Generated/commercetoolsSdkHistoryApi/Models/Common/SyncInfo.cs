using System;

namespace commercetools.Sdk.HistoryApi.Models.Common
{

    public partial class SyncInfo : ISyncInfo
    {
        public IChannelReference Channel { get; set; }

        public string ExternalId { get; set; }

        public DateTime SyncedAt { get; set; }
    }
}
