using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.PaymentMethodDefaultSetMessage))]
    public partial interface IPaymentMethodDefaultSetMessage : IMessage
    {
        bool Default { get; set; }

        bool OldDefault { get; set; }

    }
}
