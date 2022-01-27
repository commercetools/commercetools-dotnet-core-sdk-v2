using commercetools.Api.Models.Payments;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.OrderPaymentAddedMessagePayload))]
    public partial interface IOrderPaymentAddedMessagePayload : IMessagePayload
    {
        IPaymentReference Payment { get; set; }
    }
}
