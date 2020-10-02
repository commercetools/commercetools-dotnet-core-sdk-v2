using commercetools.Api.Models.Channels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    public partial class SyncInfo 
    {
        public ChannelReference Channel { get; set;}
        
        public string ExternalId { get; set;}
        
        public DateTime SyncedAt { get; set;}
    }
}
