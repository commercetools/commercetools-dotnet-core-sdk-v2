using commercetools.Api.Models.Payments;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Api.Models.Carts.CartRemovePaymentAction))]
    public partial interface ICartRemovePaymentAction : ICartUpdateAction
    {
        IPaymentResourceIdentifier Payment { get; set;}
    }
}
