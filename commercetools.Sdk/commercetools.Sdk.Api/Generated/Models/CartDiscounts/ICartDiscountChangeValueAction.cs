using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.CartDiscounts
{
    [DeserializeAs(typeof(commercetools.Api.Models.CartDiscounts.CartDiscountChangeValueAction))]
    public partial interface ICartDiscountChangeValueAction : ICartDiscountUpdateAction
    {
        ICartDiscountValueDraft Value { get; set; }
    }
}
