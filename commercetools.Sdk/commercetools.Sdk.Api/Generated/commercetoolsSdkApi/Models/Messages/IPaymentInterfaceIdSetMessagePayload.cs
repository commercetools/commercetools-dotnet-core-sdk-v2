using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.PaymentInterfaceIdSetMessagePayload))]
    public partial interface IPaymentInterfaceIdSetMessagePayload : IMessagePayload
    {
        string InterfaceId { get; set; }

        string OldInterfaceId { get; set; }

    }
}
