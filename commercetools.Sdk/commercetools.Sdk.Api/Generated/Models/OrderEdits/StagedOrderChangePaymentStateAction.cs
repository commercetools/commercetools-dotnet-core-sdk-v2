using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    public partial class StagedOrderChangePaymentStateAction : IStagedOrderChangePaymentStateAction
    {
        public string Action { get; set; }

        public IPaymentState PaymentState { get; set; }
        public StagedOrderChangePaymentStateAction()
        {
            this.Action = "changePaymentState";
        }
    }
}
