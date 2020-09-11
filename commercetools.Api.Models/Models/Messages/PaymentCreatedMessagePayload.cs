using commercetools.Api.Models.Messages;
using commercetools.Api.Models.Payments;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Messages
{
    public class PaymentCreatedMessagePayload : MessagePayload
    {
        public Payment Payment { get; set;}
    }
}
