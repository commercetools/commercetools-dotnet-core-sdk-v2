using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.DiscountCodes
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.DiscountCodes.DiscountCodeSetCartPredicateAction))]
    public partial interface IDiscountCodeSetCartPredicateAction : IDiscountCodeUpdateAction
    {
        string CartPredicate { get; set; }

    }
}
