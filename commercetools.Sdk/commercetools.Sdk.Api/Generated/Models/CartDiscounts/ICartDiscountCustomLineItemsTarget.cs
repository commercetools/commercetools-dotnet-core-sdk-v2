using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.CartDiscounts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountCustomLineItemsTarget))]
    public partial interface ICartDiscountCustomLineItemsTarget : ICartDiscountTarget
    {
        string Predicate { get; set; }

    }
}
