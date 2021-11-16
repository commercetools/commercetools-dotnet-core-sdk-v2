using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.CartDiscounts
{
    [DeserializeAs(typeof(commercetools.Api.Models.CartDiscounts.CartDiscountCustomLineItemsTarget))]
    public partial interface ICartDiscountCustomLineItemsTarget : ICartDiscountTarget
    {
        string Predicate { get; set; }
    }
}
