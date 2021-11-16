using commercetools.ImportApi.Models.Common;
using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Orders
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Orders.SyncInfo))]
    public partial interface ISyncInfo 
    {
        IChannelKeyReference Channel { get; set;}
        
        string ExternalId { get; set;}
        
        DateTime SyncedAt { get; set;}
    }
}
