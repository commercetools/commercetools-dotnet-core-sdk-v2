using commercetools.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Payments
{
    [DeserializeAs(typeof(commercetools.Api.Models.Payments.PaymentChangeAmountPlannedAction))]
    public partial interface IPaymentChangeAmountPlannedAction : IPaymentUpdateAction
    {
        IMoney Amount { get; set; }
    }
}
