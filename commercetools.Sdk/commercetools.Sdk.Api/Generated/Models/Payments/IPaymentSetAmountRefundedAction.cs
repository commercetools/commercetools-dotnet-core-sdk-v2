using commercetools.Api.Models.Common;
using commercetools.Api.Models.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Payments
{
    [DeserializeAs(typeof(commercetools.Api.Models.Payments.PaymentSetAmountRefundedAction))]
    public partial interface IPaymentSetAmountRefundedAction : IPaymentUpdateAction
    {
        IMoney Amount { get; set; }
    }
}
