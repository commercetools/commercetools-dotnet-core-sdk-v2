using commercetools.Sdk.Api.Models.PaymentMethods;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.PaymentMethodPaymentMethodStatusSetMessagePayload))]
    public partial interface IPaymentMethodPaymentMethodStatusSetMessagePayload : IMessagePayload
    {
        IPaymentMethodStatus Status { get; set; }

        IPaymentMethodStatus OldStatus { get; set; }

    }
}
