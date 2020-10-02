using commercetools.Api.Models.Carts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [DiscriminatorValue("setShippingMethodTaxAmount")]
    public partial class CartSetShippingMethodTaxAmountAction : CartUpdateAction
    {
        public ExternalTaxAmountDraft ExternalTaxAmount { get; set;}
        public CartSetShippingMethodTaxAmountAction()
        { 
           this.Action = "setShippingMethodTaxAmount";
        }
    }
}
