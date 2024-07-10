using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.ImportApi.Models.Orders
{

    public partial class TrackingData : ITrackingData
    {
        public string TrackingId { get; set; }

        public string Carrier { get; set; }

        public string Provider { get; set; }

        public string ProviderTransaction { get; set; }

        public bool? IsReturn { get; set; }
    }
}
