using commercetools.Sdk.Api.Models.Payments;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Me.MyCartAddPaymentAction))]
    public partial interface IMyCartAddPaymentAction : IMyCartUpdateAction
    {
        IPaymentResourceIdentifier Payment { get; set; }
    }
}
