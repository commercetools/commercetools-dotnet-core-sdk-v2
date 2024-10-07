using commercetools.Sdk.ImportApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.ImportApi.Models.Orders
{

    public partial class Delivery : IDelivery
    {
        public string Id { get; set; }

        public DateTime CreatedAt { get; set; }

        public IList<IDeliveryItem> Items { get; set; }

        public IEnumerable<IDeliveryItem> ItemsEnumerable { set => Items = value.ToList(); }

        public IList<IParcel> Parcels { get; set; }

        public IEnumerable<IParcel> ParcelsEnumerable { set => Parcels = value.ToList(); }

        public IAddress Address { get; set; }
    }
}
