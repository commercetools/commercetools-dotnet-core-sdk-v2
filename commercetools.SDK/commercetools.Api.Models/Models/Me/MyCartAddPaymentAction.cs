using commercetools.Api.Models.Me;
using commercetools.Api.Models.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DiscriminatorValue("addPayment")]
    public partial class MyCartAddPaymentAction : MyCartUpdateAction
    {
        public PaymentResourceIdentifier Payment { get; set;}
        public MyCartAddPaymentAction()
        { 
           this.Action = "addPayment";
        }
    }
}
