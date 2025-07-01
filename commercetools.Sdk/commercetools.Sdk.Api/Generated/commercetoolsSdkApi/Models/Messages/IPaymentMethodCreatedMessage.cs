using commercetools.Sdk.Api.Models.PaymentMethods;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.PaymentMethodCreatedMessage))]
    public partial interface IPaymentMethodCreatedMessage : IMessage
    {
        IPaymentMethod PaymentMethod { get; set; }

    }
}
