using commercetools.Api.Models.Channels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    public partial class SyncInfo : ISyncInfo
    {
        public IChannelReference Channel { get; set;}
        
        public string ExternalId { get; set;}
        
        public DateTime SyncedAt { get; set;}
    }
}
