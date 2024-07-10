using commercetools.Sdk.Api.Models.Messages;
using commercetools.Sdk.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class ParcelMeasurementsUpdatedMessagePayload : IParcelMeasurementsUpdatedMessagePayload
    {
        public string Type { get; set; }

        public string DeliveryId { get; set; }

        public string ParcelId { get; set; }

        public IParcelMeasurements Measurements { get; set; }

        public string ShippingKey { get; set; }
        public ParcelMeasurementsUpdatedMessagePayload()
        {
            this.Type = "ParcelMeasurementsUpdated";
        }
    }
}
