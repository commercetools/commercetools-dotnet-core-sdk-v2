using commercetools.Api.Models.Subscriptions;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Subscriptions
{
    [DiscriminatorValue("CloudEvents")]
    public class DeliveryCloudEventsFormat : DeliveryFormat
    {
        public string CloudEventsVersion { get; set;}
    }
}
