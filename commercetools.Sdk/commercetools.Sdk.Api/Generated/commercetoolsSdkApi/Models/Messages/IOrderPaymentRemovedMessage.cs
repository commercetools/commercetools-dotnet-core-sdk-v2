using commercetools.Sdk.Api.Models.Payments;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.OrderPaymentRemovedMessage))]
    public partial interface IOrderPaymentRemovedMessage : IMessage
    {
        IPaymentReference PaymentRef { get; set; }

        bool RemovedPaymentInfo { get; set; }

    }
}
