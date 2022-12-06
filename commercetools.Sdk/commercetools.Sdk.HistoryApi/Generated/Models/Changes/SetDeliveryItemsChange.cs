using commercetools.Sdk.HistoryApi.Models.Common;
using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class SetDeliveryItemsChange : ISetDeliveryItemsChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public string DeliveryId { get; set; }

        public IList<IDeliveryItem> NextValue { get; set; }
        public IEnumerable<IDeliveryItem> NextValueEnumerable { set => NextValue = value.ToList(); }


        public IList<IDeliveryItem> PreviousValue { get; set; }
        public IEnumerable<IDeliveryItem> PreviousValueEnumerable { set => PreviousValue = value.ToList(); }

        public SetDeliveryItemsChange()
        {
            this.Type = "SetDeliveryItemsChange";
        }
    }
}
