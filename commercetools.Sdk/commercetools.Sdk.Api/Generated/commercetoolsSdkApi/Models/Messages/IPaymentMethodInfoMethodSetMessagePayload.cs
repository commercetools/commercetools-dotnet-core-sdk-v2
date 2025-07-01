using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.PaymentMethodInfoMethodSetMessagePayload))]
    public partial interface IPaymentMethodInfoMethodSetMessagePayload : IMessagePayload
    {
        string Method { get; set; }

        string OldMethod { get; set; }

    }
}
