using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DiscriminatorValue("setCustomLineItemTaxAmount")]
    public partial class StagedOrderSetCustomLineItemTaxAmountAction : StagedOrderUpdateAction
    {
        public string CustomLineItemId { get; set;}
        
        public ExternalTaxAmountDraft ExternalTaxAmount { get; set;}
        public StagedOrderSetCustomLineItemTaxAmountAction()
        { 
           this.Action = "setCustomLineItemTaxAmount";
        }
    }
}
