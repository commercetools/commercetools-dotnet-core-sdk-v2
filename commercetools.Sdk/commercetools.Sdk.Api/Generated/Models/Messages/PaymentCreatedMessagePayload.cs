using commercetools.Sdk.Api.Models.Messages;
using commercetools.Sdk.Api.Models.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class PaymentCreatedMessagePayload : IPaymentCreatedMessagePayload
    {
        public string Type { get; set; }

        public IPayment Payment { get; set; }
        public PaymentCreatedMessagePayload()
        {
            this.Type = "PaymentCreated";
        }
    }
}
