using commercetools.Sdk.Api.Models.CartDiscounts;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.DirectDiscount))]
    public partial interface IDirectDiscount
    {
        string Id { get; set; }

        ICartDiscountValue Value { get; set; }

        ICartDiscountTarget Target { get; set; }

    }
}
