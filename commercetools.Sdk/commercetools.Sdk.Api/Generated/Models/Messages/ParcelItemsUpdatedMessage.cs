using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class ParcelItemsUpdatedMessage : IParcelItemsUpdatedMessage
    {
        public string Id { get; set; }

        public long Version { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime LastModifiedAt { get; set; }

        public ILastModifiedBy LastModifiedBy { get; set; }

        public ICreatedBy CreatedBy { get; set; }

        public long SequenceNumber { get; set; }

        public IReference Resource { get; set; }

        public long ResourceVersion { get; set; }

        public string Type { get; set; }

        public IUserProvidedIdentifiers ResourceUserProvidedIdentifiers { get; set; }

        public string ParcelId { get; set; }

        public string DeliveryId { get; set; }

        public IList<IDeliveryItem> Items { get; set; }
        public IEnumerable<IDeliveryItem> ItemsEnumerable { set => Items = value.ToList(); }


        public IList<IDeliveryItem> OldItems { get; set; }
        public IEnumerable<IDeliveryItem> OldItemsEnumerable { set => OldItems = value.ToList(); }


        public string ShippingKey { get; set; }
        public ParcelItemsUpdatedMessage()
        {
            this.Type = "ParcelItemsUpdated";
        }
    }
}
