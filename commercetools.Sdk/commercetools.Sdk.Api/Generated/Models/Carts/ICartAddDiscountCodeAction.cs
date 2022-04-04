using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.CartAddDiscountCodeAction))]
    public partial interface ICartAddDiscountCodeAction : ICartUpdateAction
    {
        string Code { get; set; }
    }
}
