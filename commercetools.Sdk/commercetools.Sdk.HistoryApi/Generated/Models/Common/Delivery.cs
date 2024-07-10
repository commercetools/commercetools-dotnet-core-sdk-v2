using commercetools.Sdk.HistoryApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.HistoryApi.Models.Common
{

    public partial class Delivery : IDelivery
    {
        public string Id { get; set; }

        public string CreatedAt { get; set; }

        public IList<IDeliveryItem> Items { get; set; }
        public IEnumerable<IDeliveryItem> ItemsEnumerable { set => Items = value.ToList(); }


        public IList<IParcel> Parcels { get; set; }
        public IEnumerable<IParcel> ParcelsEnumerable { set => Parcels = value.ToList(); }


        public IAddress Address { get; set; }

        public ICustomFields Custom { get; set; }
    }
}
