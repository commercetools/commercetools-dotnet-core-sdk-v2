using commercetools.Sdk.Api.Models.DiscountCodes;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.CartRemoveDiscountCodeAction))]
    public partial interface ICartRemoveDiscountCodeAction : ICartUpdateAction
    {
        IDiscountCodeReference DiscountCode { get; set; }

    }
}
