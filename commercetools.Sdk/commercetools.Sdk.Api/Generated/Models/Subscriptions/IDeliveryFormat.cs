using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Subscriptions
{
    [TypeDiscriminator(nameof(Type))]
    [SubTypeDiscriminator("Platform", typeof(commercetools.Api.Models.Subscriptions.DeliveryPlatformFormat))]
    [SubTypeDiscriminator("CloudEvents", typeof(commercetools.Api.Models.Subscriptions.DeliveryCloudEventsFormat))]
    public interface IDeliveryFormat 
    {
        string Type { get; set;}
    }
}
