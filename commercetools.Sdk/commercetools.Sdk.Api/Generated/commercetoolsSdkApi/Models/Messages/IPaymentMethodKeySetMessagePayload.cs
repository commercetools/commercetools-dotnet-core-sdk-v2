using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.PaymentMethodKeySetMessagePayload))]
    public partial interface IPaymentMethodKeySetMessagePayload : IMessagePayload
    {
        string Key { get; set; }

        string OldKey { get; set; }

    }
}
