using commercetools.Sdk.Api.Models.Types;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.PaymentInteractionAddedMessagePayload))]
    public partial interface IPaymentInteractionAddedMessagePayload : IMessagePayload
    {
        ICustomFields Interaction { get; set; }

    }
}
