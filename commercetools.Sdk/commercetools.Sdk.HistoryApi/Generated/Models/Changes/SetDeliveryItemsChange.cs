using commercetools.Sdk.HistoryApi.Models.Common;
using System.Collections.Generic;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class SetDeliveryItemsChange : ISetDeliveryItemsChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public string DeliveryId { get; set; }

        public List<IDeliveryItem> NextValue { get; set; }

        public List<IDeliveryItem> PreviousValue { get; set; }
        public SetDeliveryItemsChange()
        {
            this.Type = "SetDeliveryItemsChange";
        }
    }
}
