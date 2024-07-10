using commercetools.Sdk.ImportApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.ImportApi.Models.Orders
{

    public partial class SyncInfo : ISyncInfo
    {
        public IChannelKeyReference Channel { get; set; }

        public string ExternalId { get; set; }

        public DateTime SyncedAt { get; set; }
    }
}
