using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [DiscriminatorValue("removePayment")]
    public partial class CartRemovePaymentAction : CartUpdateAction
    {
        public PaymentResourceIdentifier Payment { get; set;}
        public CartRemovePaymentAction()
        { 
           this.Action = "removePayment";
        }
    }
}
