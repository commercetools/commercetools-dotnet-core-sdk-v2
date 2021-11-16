using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.CartDiscounts
{
    [DeserializeAs(typeof(commercetools.Api.Models.CartDiscounts.CartDiscountLineItemsTarget))]
    public partial interface ICartDiscountLineItemsTarget : ICartDiscountTarget
    {
        string Predicate { get; set; }
    }
}
