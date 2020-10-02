using commercetools.Api.Models.Carts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [DiscriminatorValue("setCustomLineItemTaxAmount")]
    public partial class CartSetCustomLineItemTaxAmountAction : CartUpdateAction
    {
        public string CustomLineItemId { get; set;}
        
        public ExternalTaxAmountDraft ExternalTaxAmount { get; set;}
        public CartSetCustomLineItemTaxAmountAction()
        { 
           this.Action = "setCustomLineItemTaxAmount";
        }
    }
}
