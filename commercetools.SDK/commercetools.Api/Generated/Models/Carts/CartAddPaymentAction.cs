using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [DiscriminatorValue("addPayment")]
    public partial class CartAddPaymentAction : CartUpdateAction
    {
        public PaymentResourceIdentifier Payment { get; set;}
        public CartAddPaymentAction()
        { 
           this.Action = "addPayment";
        }
    }
}
