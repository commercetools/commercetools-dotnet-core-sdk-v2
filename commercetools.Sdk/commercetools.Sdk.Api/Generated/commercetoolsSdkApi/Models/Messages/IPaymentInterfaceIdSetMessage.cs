using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.PaymentInterfaceIdSetMessage))]
    public partial interface IPaymentInterfaceIdSetMessage : IMessage
    {
        string InterfaceId { get; set; }

        string OldInterfaceId { get; set; }

    }
}
