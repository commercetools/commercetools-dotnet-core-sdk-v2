using commercetools.Sdk.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.OrderEdits
{

    public partial class StagedOrderChangeCustomLineItemQuantityAction : IStagedOrderChangeCustomLineItemQuantityAction
    {
        public string Action { get; set; }

        public string CustomLineItemId { get; set; }

        public string CustomLineItemKey { get; set; }

        public long Quantity { get; set; }
        public StagedOrderChangeCustomLineItemQuantityAction()
        {
            this.Action = "changeCustomLineItemQuantity";
        }
    }
}
