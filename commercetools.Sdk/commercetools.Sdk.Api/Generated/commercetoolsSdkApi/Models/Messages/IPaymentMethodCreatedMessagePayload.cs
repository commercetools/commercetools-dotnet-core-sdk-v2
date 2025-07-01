using commercetools.Sdk.Api.Models.PaymentMethods;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.PaymentMethodCreatedMessagePayload))]
    public partial interface IPaymentMethodCreatedMessagePayload : IMessagePayload
    {
        IPaymentMethod PaymentMethod { get; set; }

    }
}
