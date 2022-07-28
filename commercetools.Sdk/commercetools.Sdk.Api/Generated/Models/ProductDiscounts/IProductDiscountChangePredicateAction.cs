using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.ProductDiscounts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductDiscounts.ProductDiscountChangePredicateAction))]
    public partial interface IProductDiscountChangePredicateAction : IProductDiscountUpdateAction
    {
        string Predicate { get; set; }

    }
}
