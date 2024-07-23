using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Payments
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Payments.PaymentSetAnonymousIdAction))]
    public partial interface IPaymentSetAnonymousIdAction : IPaymentUpdateAction
    {
        string AnonymousId { get; set; }

    }
}
