using commercetools.Api.Models.Types;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.PaymentInteractionAddedMessagePayload))]
    public partial interface IPaymentInteractionAddedMessagePayload : IMessagePayload
    {
        ICustomFields Interaction { get; set; }
    }
}
