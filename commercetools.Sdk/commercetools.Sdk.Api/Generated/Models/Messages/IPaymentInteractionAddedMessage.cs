using commercetools.Api.Models.Types;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.PaymentInteractionAddedMessage))]
    public partial interface IPaymentInteractionAddedMessage : IMessage
    {
        ICustomFields Interaction { get; set; }
    }
}
