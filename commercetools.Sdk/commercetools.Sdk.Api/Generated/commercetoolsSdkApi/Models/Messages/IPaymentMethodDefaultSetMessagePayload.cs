using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.PaymentMethodDefaultSetMessagePayload))]
    public partial interface IPaymentMethodDefaultSetMessagePayload : IMessagePayload
    {
        bool Default { get; set; }

        bool OldDefault { get; set; }

    }
}
