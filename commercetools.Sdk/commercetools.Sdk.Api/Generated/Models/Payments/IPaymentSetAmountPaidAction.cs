using commercetools.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Payments
{
    [DeserializeAs(typeof(commercetools.Api.Models.Payments.PaymentSetAmountPaidAction))]
    public partial interface IPaymentSetAmountPaidAction : IPaymentUpdateAction
    {
        IMoney Amount { get; set; }
    }
}
