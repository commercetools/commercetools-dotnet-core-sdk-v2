using commercetools.Api.Models.States;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Payments
{
    [DeserializeAs(typeof(commercetools.Api.Models.Payments.PaymentStatus))]
    public partial interface IPaymentStatus 
    {
        string InterfaceCode { get; set;}
        
        string InterfaceText { get; set;}
        
        IStateReference State { get; set;}
    }
}
