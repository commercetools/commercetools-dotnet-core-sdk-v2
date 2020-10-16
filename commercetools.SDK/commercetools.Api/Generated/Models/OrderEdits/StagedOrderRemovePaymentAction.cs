using commercetools.Api.Models.Orders;
using commercetools.Api.Models.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DiscriminatorValue("removePayment")]
    public partial class StagedOrderRemovePaymentAction : StagedOrderUpdateAction
    {
        public PaymentResourceIdentifier Payment { get; set;}
        public StagedOrderRemovePaymentAction()
        { 
           this.Action = "removePayment";
        }
    }
}
