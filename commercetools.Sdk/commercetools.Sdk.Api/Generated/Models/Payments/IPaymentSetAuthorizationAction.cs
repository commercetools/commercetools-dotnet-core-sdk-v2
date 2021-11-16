using commercetools.Api.Models.Common;
using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Payments
{
    [DeserializeAs(typeof(commercetools.Api.Models.Payments.PaymentSetAuthorizationAction))]
    public partial interface IPaymentSetAuthorizationAction : IPaymentUpdateAction
    {
        IMoney Amount { get; set; }

        DateTime? Until { get; set; }
    }
}
