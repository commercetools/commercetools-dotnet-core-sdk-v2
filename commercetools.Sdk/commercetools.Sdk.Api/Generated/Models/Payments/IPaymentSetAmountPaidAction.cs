using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Payments
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Payments.PaymentSetAmountPaidAction))]
    public partial interface IPaymentSetAmountPaidAction : IPaymentUpdateAction
    {
        IMoney Amount { get; set; }
    }
}
