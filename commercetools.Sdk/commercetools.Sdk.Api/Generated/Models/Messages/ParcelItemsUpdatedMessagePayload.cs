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

    public partial class ParcelItemsUpdatedMessagePayload : IParcelItemsUpdatedMessagePayload
    {
        public string Type { get; set; }

        public string ParcelId { get; set; }

        public string DeliveryId { get; set; }

        public IList<IDeliveryItem> Items { get; set; }
        public IEnumerable<IDeliveryItem> ItemsEnumerable { set => Items = value.ToList(); }


        public IList<IDeliveryItem> OldItems { get; set; }
        public IEnumerable<IDeliveryItem> OldItemsEnumerable { set => OldItems = value.ToList(); }


        public string ShippingKey { get; set; }
        public ParcelItemsUpdatedMessagePayload()
        {
            this.Type = "ParcelItemsUpdated";
        }
    }
}
