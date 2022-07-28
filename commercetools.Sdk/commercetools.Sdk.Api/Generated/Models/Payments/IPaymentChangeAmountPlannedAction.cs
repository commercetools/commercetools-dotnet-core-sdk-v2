using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Payments
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Payments.PaymentChangeAmountPlannedAction))]
    public partial interface IPaymentChangeAmountPlannedAction : IPaymentUpdateAction
    {
        IMoney Amount { get; set; }

    }
}
