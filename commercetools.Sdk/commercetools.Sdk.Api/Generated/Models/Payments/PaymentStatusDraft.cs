using commercetools.Api.Models.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Payments
{
    public partial class PaymentStatusDraft : IPaymentStatusDraft
    {
        public string InterfaceCode { get; set; }

        public string InterfaceText { get; set; }

        public IStateResourceIdentifier State { get; set; }
    }
}
