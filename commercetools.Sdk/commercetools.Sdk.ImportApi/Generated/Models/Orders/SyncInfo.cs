using commercetools.Sdk.ImportApi.Models.Common;
using System;


namespace commercetools.Sdk.ImportApi.Models.Orders
{
    public partial class SyncInfo : ISyncInfo
    {
        public IChannelKeyReference Channel { get; set; }

        public string ExternalId { get; set; }

        public DateTime SyncedAt { get; set; }
    }
}
