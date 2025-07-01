using commercetools.Sdk.Api.Models.PaymentMethods;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.PaymentMethodPaymentMethodStatusSetMessage))]
    public partial interface IPaymentMethodPaymentMethodStatusSetMessage : IMessage
    {
        IPaymentMethodStatus Status { get; set; }

        IPaymentMethodStatus OldStatus { get; set; }

    }
}
