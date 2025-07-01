using commercetools.Sdk.Api.Models.PaymentMethods;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.PaymentMethodInfoTokenSetMessagePayload))]
    public partial interface IPaymentMethodInfoTokenSetMessagePayload : IMessagePayload
    {
        IPaymentMethodToken Token { get; set; }

        IPaymentMethodToken OldToken { get; set; }

    }
}
