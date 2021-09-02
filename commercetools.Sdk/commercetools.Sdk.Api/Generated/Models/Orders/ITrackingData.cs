using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Api.Models.Orders.TrackingData))]
    public partial interface ITrackingData
    {
        string TrackingId { get; set; }

        string Carrier { get; set; }

        string Provider { get; set; }

        string ProviderTransaction { get; set; }

        bool? IsReturn { get; set; }
    }
}
