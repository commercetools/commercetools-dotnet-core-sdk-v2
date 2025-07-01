using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.PaymentMethodPaymentInterfaceSetMessagePayload))]
    public partial interface IPaymentMethodPaymentInterfaceSetMessagePayload : IMessagePayload
    {
        string PaymentInterface { get; set; }

        string OldPaymentInterface { get; set; }

    }
}
