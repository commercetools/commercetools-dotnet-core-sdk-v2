using commercetools.Api.Models.Orders;
using commercetools.Api.Models.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DiscriminatorValue("addPayment")]
    public partial class StagedOrderAddPaymentAction : StagedOrderUpdateAction
    {
        public PaymentResourceIdentifier Payment { get; set;}
        public StagedOrderAddPaymentAction()
        { 
           this.Action = "addPayment";
        }
    }
}
