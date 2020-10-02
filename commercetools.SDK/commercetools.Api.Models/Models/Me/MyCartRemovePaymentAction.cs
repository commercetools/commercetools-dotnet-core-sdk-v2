using commercetools.Api.Models.Me;
using commercetools.Api.Models.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DiscriminatorValue("removePayment")]
    public partial class MyCartRemovePaymentAction : MyCartUpdateAction
    {
        public PaymentResourceIdentifier Payment { get; set;}
        public MyCartRemovePaymentAction()
        { 
           this.Action = "removePayment";
        }
    }
}
