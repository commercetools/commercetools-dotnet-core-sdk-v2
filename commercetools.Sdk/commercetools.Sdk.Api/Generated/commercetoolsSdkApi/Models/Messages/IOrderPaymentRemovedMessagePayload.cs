using commercetools.Sdk.Api.Models.Payments;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.OrderPaymentRemovedMessagePayload))]
    public partial interface IOrderPaymentRemovedMessagePayload : IMessagePayload
    {
        IPaymentReference PaymentRef { get; set; }

        bool RemovedPaymentInfo { get; set; }

    }
}
