using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Api.Models.Carts.CartAddDiscountCodeAction))]
    public partial interface ICartAddDiscountCodeAction : ICartUpdateAction
    {
        string Code { get; set;}
    }
}
