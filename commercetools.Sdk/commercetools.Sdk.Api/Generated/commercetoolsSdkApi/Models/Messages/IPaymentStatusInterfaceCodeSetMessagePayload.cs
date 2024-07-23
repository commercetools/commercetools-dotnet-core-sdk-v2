using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.PaymentStatusInterfaceCodeSetMessagePayload))]
    public partial interface IPaymentStatusInterfaceCodeSetMessagePayload : IMessagePayload
    {
        string InterfaceCode { get; set; }

    }
}
