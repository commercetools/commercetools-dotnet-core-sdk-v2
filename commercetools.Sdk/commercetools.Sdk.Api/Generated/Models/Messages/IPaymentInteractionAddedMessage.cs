using commercetools.Sdk.Api.Models.Types;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.PaymentInteractionAddedMessage))]
    public partial interface IPaymentInteractionAddedMessage : IMessage
    {
        ICustomFields Interaction { get; set; }
    }
}
