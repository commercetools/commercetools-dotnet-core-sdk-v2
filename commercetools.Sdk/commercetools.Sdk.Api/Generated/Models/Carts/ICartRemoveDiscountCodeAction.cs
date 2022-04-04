using commercetools.Sdk.Api.Models.DiscountCodes;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.CartRemoveDiscountCodeAction))]
    public partial interface ICartRemoveDiscountCodeAction : ICartUpdateAction
    {
        IDiscountCodeReference DiscountCode { get; set; }
    }
}
