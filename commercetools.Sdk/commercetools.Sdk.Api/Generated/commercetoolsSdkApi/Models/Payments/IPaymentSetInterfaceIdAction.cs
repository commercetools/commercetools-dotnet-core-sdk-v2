using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Payments
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Payments.PaymentSetInterfaceIdAction))]
    public partial interface IPaymentSetInterfaceIdAction : IPaymentUpdateAction
    {
        string InterfaceId { get; set; }

    }
}
