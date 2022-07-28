using commercetools.Sdk.Api.Models.Payments;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.OrderPaymentAddedMessagePayload))]
    public partial interface IOrderPaymentAddedMessagePayload : IMessagePayload
    {
        IPaymentReference Payment { get; set; }

    }
}
