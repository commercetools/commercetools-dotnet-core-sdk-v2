using commercetools.Api.Models.Carts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    public partial class CartSetCustomLineItemTaxAmountAction : ICartSetCustomLineItemTaxAmountAction
    {
        public string Action { get; set;}
        
        public string CustomLineItemId { get; set;}
        
        public IExternalTaxAmountDraft ExternalTaxAmount { get; set;}
        public CartSetCustomLineItemTaxAmountAction()
        { 
           this.Action = "setCustomLineItemTaxAmount";
        }
    }
}
