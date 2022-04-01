using commercetools.Sdk.Api.Models.Payments;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.CartRemovePaymentAction))]
    public partial interface ICartRemovePaymentAction : ICartUpdateAction
    {
        IPaymentResourceIdentifier Payment { get; set; }
    }
}
