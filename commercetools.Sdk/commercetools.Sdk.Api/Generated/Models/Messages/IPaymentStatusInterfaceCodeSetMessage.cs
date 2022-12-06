using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.PaymentStatusInterfaceCodeSetMessage))]
    public partial interface IPaymentStatusInterfaceCodeSetMessage : IMessage
    {
        string PaymentId { get; set; }

        string InterfaceCode { get; set; }

    }
}
