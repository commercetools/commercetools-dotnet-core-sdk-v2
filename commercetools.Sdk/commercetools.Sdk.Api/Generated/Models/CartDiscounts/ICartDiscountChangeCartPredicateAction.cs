using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.CartDiscounts
{
    [DeserializeAs(typeof(commercetools.Api.Models.CartDiscounts.CartDiscountChangeCartPredicateAction))]
    public partial interface ICartDiscountChangeCartPredicateAction : ICartDiscountUpdateAction
    {
        string CartPredicate { get; set; }
    }
}
