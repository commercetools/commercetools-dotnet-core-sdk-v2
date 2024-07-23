using commercetools.Sdk.Api.Models.Payments;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.PaymentCreatedMessagePayload))]
    public partial interface IPaymentCreatedMessagePayload : IMessagePayload
    {
        IPayment Payment { get; set; }

    }
}
