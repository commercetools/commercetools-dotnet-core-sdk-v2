using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    public partial class StagedOrderSetParcelItemsAction : IStagedOrderSetParcelItemsAction
    {
        public string Action { get; set; }

        public string ParcelId { get; set; }

        public List<IDeliveryItem> Items { get; set; }
        public StagedOrderSetParcelItemsAction()
        {
            this.Action = "setParcelItems";
        }
    }
}
