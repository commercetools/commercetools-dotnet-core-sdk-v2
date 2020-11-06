using commercetools.Api.Models.Common;
using commercetools.Api.Models.Messages;
using commercetools.Api.Models.Subscriptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Subscriptions
{
    [DeserializeAs(typeof(commercetools.Api.Models.Subscriptions.ResourceCreatedDelivery))]
    public partial interface IResourceCreatedDelivery : ISubscriptionDelivery
    {
        long Version { get; set;}
        
        DateTime ModifiedAt { get; set;}
    }
}
