using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.PaymentStatusInterfaceCodeSetMessage))]
    public partial interface IPaymentStatusInterfaceCodeSetMessage : IMessage
    {
        string PaymentId { get; set;}
        
        string InterfaceCode { get; set;}
    }
}
