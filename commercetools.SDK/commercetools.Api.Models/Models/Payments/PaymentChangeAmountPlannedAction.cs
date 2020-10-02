using commercetools.Api.Models.Common;
using commercetools.Api.Models.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Payments
{
    [DiscriminatorValue("changeAmountPlanned")]
    public partial class PaymentChangeAmountPlannedAction : PaymentUpdateAction
    {
        public Money Amount { get; set;}
        public PaymentChangeAmountPlannedAction()
        { 
           this.Action = "changeAmountPlanned";
        }
    }
}
