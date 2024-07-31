using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.CartAddDiscountCodeAction))]
    public partial interface ICartAddDiscountCodeAction : ICartUpdateAction
    {
        string Code { get; set; }

    }
}
