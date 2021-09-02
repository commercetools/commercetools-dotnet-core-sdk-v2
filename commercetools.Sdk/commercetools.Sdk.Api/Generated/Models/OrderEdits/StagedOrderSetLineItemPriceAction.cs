using commercetools.Api.Models.Common;
using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    public partial class StagedOrderSetLineItemPriceAction : IStagedOrderSetLineItemPriceAction
    {
        public string Action { get; set; }

        public string LineItemId { get; set; }

        public IMoney ExternalPrice { get; set; }
        public StagedOrderSetLineItemPriceAction()
        {
            this.Action = "setLineItemPrice";
        }
    }
}
