using commercetools.Api.Models.Payments;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Api.Models.Me.MyCartAddPaymentAction))]
    public partial interface IMyCartAddPaymentAction : IMyCartUpdateAction
    {
        IPaymentResourceIdentifier Payment { get; set;}
    }
}
