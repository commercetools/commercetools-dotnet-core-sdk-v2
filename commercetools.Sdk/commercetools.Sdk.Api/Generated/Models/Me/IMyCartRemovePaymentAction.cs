using commercetools.Api.Models.Payments;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Api.Models.Me.MyCartRemovePaymentAction))]
    public partial interface IMyCartRemovePaymentAction : IMyCartUpdateAction
    {
        IPaymentResourceIdentifier Payment { get; set;}
    }
}
