using commercetools.Api.Models.Channels;
using System;


namespace commercetools.Api.Models.Orders
{
    public partial class SyncInfo : ISyncInfo
    {
        public IChannelReference Channel { get; set; }

        public string ExternalId { get; set; }

        public DateTime SyncedAt { get; set; }
    }
}
