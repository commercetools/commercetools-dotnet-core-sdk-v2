using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Subscriptions
{
    public partial class DeliveryFormat : IDeliveryFormat
    {
        public string Type { get; set; }
    }
}
