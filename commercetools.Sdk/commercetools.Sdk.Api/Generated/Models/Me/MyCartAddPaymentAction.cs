using commercetools.Sdk.Api.Models.Me;
using commercetools.Sdk.Api.Models.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Me
{

    public partial class MyCartAddPaymentAction : IMyCartAddPaymentAction
    {
        public string Action { get; set; }

        public IPaymentResourceIdentifier Payment { get; set; }
        public MyCartAddPaymentAction()
        {
            this.Action = "addPayment";
        }
    }
}
