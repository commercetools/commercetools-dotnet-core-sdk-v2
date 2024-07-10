using commercetools.Sdk.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.OrderEdits
{

    public partial class StagedOrderSetParcelItemsAction : IStagedOrderSetParcelItemsAction
    {
        public string Action { get; set; }

        public string ParcelId { get; set; }

        public string ParcelKey { get; set; }

        public IList<IDeliveryItem> Items { get; set; }
        public IEnumerable<IDeliveryItem> ItemsEnumerable { set => Items = value.ToList(); }

        public StagedOrderSetParcelItemsAction()
        {
            this.Action = "setParcelItems";
        }
    }
}
