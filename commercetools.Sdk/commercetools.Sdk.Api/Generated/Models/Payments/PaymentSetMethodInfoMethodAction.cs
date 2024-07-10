using commercetools.Sdk.Api.Models.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Payments
{

    public partial class PaymentSetMethodInfoMethodAction : IPaymentSetMethodInfoMethodAction
    {
        public string Action { get; set; }

        public string Method { get; set; }
        public PaymentSetMethodInfoMethodAction()
        {
            this.Action = "setMethodInfoMethod";
        }
    }
}
