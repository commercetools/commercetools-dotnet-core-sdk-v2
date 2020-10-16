using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DiscriminatorValue("setLineItemTaxAmount")]
    public partial class StagedOrderSetLineItemTaxAmountAction : StagedOrderUpdateAction
    {
        public string LineItemId { get; set;}
        
        public ExternalTaxAmountDraft ExternalTaxAmount { get; set;}
        public StagedOrderSetLineItemTaxAmountAction()
        { 
           this.Action = "setLineItemTaxAmount";
        }
    }
}
