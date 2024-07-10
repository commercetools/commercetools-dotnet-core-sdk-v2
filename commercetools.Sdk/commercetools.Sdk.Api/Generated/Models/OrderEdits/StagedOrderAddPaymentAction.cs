using commercetools.Sdk.Api.Models.Orders;
using commercetools.Sdk.Api.Models.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.OrderEdits
{

    public partial class StagedOrderAddPaymentAction : IStagedOrderAddPaymentAction
    {
        public string Action { get; set; }

        public IPaymentResourceIdentifier Payment { get; set; }
        public StagedOrderAddPaymentAction()
        {
            this.Action = "addPayment";
        }
    }
}
