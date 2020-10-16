using commercetools.Api.Models.Carts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [DiscriminatorValue("setLineItemTaxAmount")]
    public partial class CartSetLineItemTaxAmountAction : CartUpdateAction
    {
        public string LineItemId { get; set;}
        
        public ExternalTaxAmountDraft ExternalTaxAmount { get; set;}
        public CartSetLineItemTaxAmountAction()
        { 
           this.Action = "setLineItemTaxAmount";
        }
    }
}
