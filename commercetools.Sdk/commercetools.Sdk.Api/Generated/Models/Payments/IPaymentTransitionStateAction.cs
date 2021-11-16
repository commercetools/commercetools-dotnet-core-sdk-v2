using commercetools.Api.Models.States;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Payments
{
    [DeserializeAs(typeof(commercetools.Api.Models.Payments.PaymentTransitionStateAction))]
    public partial interface IPaymentTransitionStateAction : IPaymentUpdateAction
    {
        IStateResourceIdentifier State { get; set;}
        
        bool? Force { get; set;}
    }
}
