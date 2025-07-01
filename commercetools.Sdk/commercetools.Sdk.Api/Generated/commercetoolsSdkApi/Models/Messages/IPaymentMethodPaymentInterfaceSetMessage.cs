using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.PaymentMethodPaymentInterfaceSetMessage))]
    public partial interface IPaymentMethodPaymentInterfaceSetMessage : IMessage
    {
        string PaymentInterface { get; set; }

        string OldPaymentInterface { get; set; }

    }
}
