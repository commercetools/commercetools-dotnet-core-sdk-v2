using commercetools.Sdk.ImportApi.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.ImportApi.Models.OrderPatches
{

    public partial class ParcelTrackingData : IParcelTrackingData
    {
        public string ParcelId { get; set; }

        public ITrackingData TrackingData { get; set; }
    }
}
