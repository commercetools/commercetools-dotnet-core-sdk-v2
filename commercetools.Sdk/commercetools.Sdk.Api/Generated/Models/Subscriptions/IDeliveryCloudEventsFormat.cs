using commercetools.Api.Models.Subscriptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Subscriptions
{
    [DeserializeAs(typeof(commercetools.Api.Models.Subscriptions.DeliveryCloudEventsFormat))]
    public interface IDeliveryCloudEventsFormat : IDeliveryFormat
    {
        string CloudEventsVersion { get; set;}
    }
}
