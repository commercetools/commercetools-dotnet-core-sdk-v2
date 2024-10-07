using commercetools.Sdk.HistoryApi.Models.Common;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.HistoryApi.Models.ChangeValues
{

    public partial class DeliveryChangeValue : IDeliveryChangeValue
    {
        public IList<IDeliveryItem> Items { get; set; }

        public IEnumerable<IDeliveryItem> ItemsEnumerable { set => Items = value.ToList(); }

        public IAddress Address { get; set; }

        public IList<IParcel> Parcels { get; set; }

        public IEnumerable<IParcel> ParcelsEnumerable { set => Parcels = value.ToList(); }
    }
}
