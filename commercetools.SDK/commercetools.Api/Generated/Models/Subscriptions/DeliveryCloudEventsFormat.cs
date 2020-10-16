using commercetools.Api.Models.Subscriptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Subscriptions
{
    [DiscriminatorValue("CloudEvents")]
    public partial class DeliveryCloudEventsFormat : DeliveryFormat
    {
        public string CloudEventsVersion { get; set;}
        public DeliveryCloudEventsFormat()
        { 
           this.Type = "CloudEvents";
        }
    }
}
