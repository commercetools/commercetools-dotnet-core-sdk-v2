using commercetools.Sdk.Api.Models.Payments;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.OrderPaymentAddedMessage))]
    public partial interface IOrderPaymentAddedMessage : IMessage
    {
        IPaymentReference Payment { get; set; }

    }
}
