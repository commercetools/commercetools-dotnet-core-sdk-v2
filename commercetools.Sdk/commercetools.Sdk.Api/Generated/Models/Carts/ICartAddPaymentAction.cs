using commercetools.Api.Models.Payments;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Api.Models.Carts.CartAddPaymentAction))]
    public partial interface ICartAddPaymentAction : ICartUpdateAction
    {
        IPaymentResourceIdentifier Payment { get; set; }
    }
}
