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

    public partial class ParcelRemovedFromDeliveryMessagePayload : IParcelRemovedFromDeliveryMessagePayload
    {
        public string Type { get; set; }

        public string DeliveryId { get; set; }

        public IParcel Parcel { get; set; }

        public string ShippingKey { get; set; }
        public ParcelRemovedFromDeliveryMessagePayload()
        {
            this.Type = "ParcelRemovedFromDelivery";
        }
    }
}
