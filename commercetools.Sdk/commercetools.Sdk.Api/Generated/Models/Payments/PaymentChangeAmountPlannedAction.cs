using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Payments
{

    public partial class PaymentChangeAmountPlannedAction : IPaymentChangeAmountPlannedAction
    {
        public string Action { get; set; }

        public IMoney Amount { get; set; }
        public PaymentChangeAmountPlannedAction()
        {
            this.Action = "changeAmountPlanned";
        }
    }
}
