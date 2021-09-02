using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Payments
{
    public partial class PaymentUpdateAction : IPaymentUpdateAction
    {
        public string Action { get; set; }
    }
}
