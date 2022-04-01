using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.CartDiscounts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountLineItemsTarget))]
    public partial interface ICartDiscountLineItemsTarget : ICartDiscountTarget
    {
        string Predicate { get; set; }
    }
}
