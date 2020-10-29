using commercetools.Api.Models.Channels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Api.Models.Orders.SyncInfo))]
    public interface ISyncInfo 
    {
        IChannelReference Channel { get; set;}
        
        string ExternalId { get; set;}
        
        DateTime SyncedAt { get; set;}
    }
}
