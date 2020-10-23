using commercetools.Api.Generated.Models.Channels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Orders
{
    public interface ISyncInfo 
    {
        IChannelReference Channel { get; set;}
        
        string ExternalId { get; set;}
        
        DateTime SyncedAt { get; set;}
    }
}
