using commercetools.Sdk.Api.Models.CartDiscounts;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.DirectDiscountDraft))]
    public partial interface IDirectDiscountDraft
    {
        ICartDiscountValue Value { get; set; }

        ICartDiscountTarget Target { get; set; }
    }
}
