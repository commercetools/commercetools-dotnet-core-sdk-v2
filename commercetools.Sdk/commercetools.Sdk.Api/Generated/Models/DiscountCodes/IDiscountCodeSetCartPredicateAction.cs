using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.DiscountCodes
{
    [DeserializeAs(typeof(commercetools.Api.Models.DiscountCodes.DiscountCodeSetCartPredicateAction))]
    public partial interface IDiscountCodeSetCartPredicateAction : IDiscountCodeUpdateAction
    {
        string CartPredicate { get; set; }
    }
}
