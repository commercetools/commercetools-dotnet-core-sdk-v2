using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    public  partial class StagedOrderSetLineItemTaxAmountAction : IStagedOrderSetLineItemTaxAmountAction
    {
        public string Action { get; set;}
        
        public string LineItemId { get; set;}
        
        public IExternalTaxAmountDraft ExternalTaxAmount { get; set;}
        public StagedOrderSetLineItemTaxAmountAction()
        { 
           this.Action = "setLineItemTaxAmount";
        }
    }
}
