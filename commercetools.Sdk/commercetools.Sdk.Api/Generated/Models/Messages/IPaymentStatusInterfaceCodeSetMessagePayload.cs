using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.PaymentStatusInterfaceCodeSetMessagePayload))]
    public partial interface IPaymentStatusInterfaceCodeSetMessagePayload : IMessagePayload
    {
        string PaymentId { get; set;}
        
        string InterfaceCode { get; set;}
    }
}
