using commercetools.Api.Models.Payments;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.OrderPaymentAddedMessage))]
    public partial interface IOrderPaymentAddedMessage : IMessage
    {
        IPaymentReference Payment { get; set; }
    }
}
