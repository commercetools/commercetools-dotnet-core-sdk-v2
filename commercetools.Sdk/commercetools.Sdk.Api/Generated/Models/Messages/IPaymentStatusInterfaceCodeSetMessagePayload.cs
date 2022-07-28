using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.PaymentStatusInterfaceCodeSetMessagePayload))]
    public partial interface IPaymentStatusInterfaceCodeSetMessagePayload : IMessagePayload
    {
        string PaymentId { get; set; }

        string InterfaceCode { get; set; }

    }
}
