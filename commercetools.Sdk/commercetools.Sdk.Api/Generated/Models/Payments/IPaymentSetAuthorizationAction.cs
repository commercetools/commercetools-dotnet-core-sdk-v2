using commercetools.Sdk.Api.Models.Common;
using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Payments
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Payments.PaymentSetAuthorizationAction))]
    public partial interface IPaymentSetAuthorizationAction : IPaymentUpdateAction
    {
        IMoney Amount { get; set; }

        DateTime? Until { get; set; }
    }
}
