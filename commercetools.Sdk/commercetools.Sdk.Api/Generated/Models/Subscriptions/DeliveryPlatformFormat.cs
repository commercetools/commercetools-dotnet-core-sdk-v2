using commercetools.Api.Models.Subscriptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Subscriptions
{
    public  partial class DeliveryPlatformFormat : IDeliveryPlatformFormat
    {
        public string Type { get; set;}
        public DeliveryPlatformFormat()
        { 
           this.Type = "Platform";
        }
    }
}
