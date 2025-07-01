using commercetools.Sdk.Api.Models.PaymentMethods;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.PaymentMethodInfoTokenSetMessage))]
    public partial interface IPaymentMethodInfoTokenSetMessage : IMessage
    {
        IPaymentMethodToken Token { get; set; }

        IPaymentMethodToken OldToken { get; set; }

    }
}
