using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.PaymentStatusInterfaceCodeSetMessage))]
    public partial interface IPaymentStatusInterfaceCodeSetMessage : IMessage
    {
        string InterfaceCode { get; set; }

    }
}
