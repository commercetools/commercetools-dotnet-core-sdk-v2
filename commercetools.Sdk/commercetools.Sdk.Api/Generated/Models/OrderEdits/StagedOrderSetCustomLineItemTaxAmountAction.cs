using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    public partial class StagedOrderSetCustomLineItemTaxAmountAction : IStagedOrderSetCustomLineItemTaxAmountAction
    {
        public string Action { get; set; }

        public string CustomLineItemId { get; set; }

        public IExternalTaxAmountDraft ExternalTaxAmount { get; set; }
        public StagedOrderSetCustomLineItemTaxAmountAction()
        {
            this.Action = "setCustomLineItemTaxAmount";
        }
    }
}
