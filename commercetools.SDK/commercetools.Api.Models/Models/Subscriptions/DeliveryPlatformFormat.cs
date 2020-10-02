using commercetools.Api.Models.Subscriptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Subscriptions
{
    [DiscriminatorValue("Platform")]
    public partial class DeliveryPlatformFormat : DeliveryFormat
    {
        public DeliveryPlatformFormat()
        { 
           this.Type = "Platform";
        }
    }
}
