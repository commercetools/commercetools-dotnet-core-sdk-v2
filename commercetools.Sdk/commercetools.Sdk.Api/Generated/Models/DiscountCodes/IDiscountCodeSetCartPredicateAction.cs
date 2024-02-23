using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.DiscountCodes
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.DiscountCodes.DiscountCodeSetCartPredicateAction))]
    public partial interface IDiscountCodeSetCartPredicateAction : IDiscountCodeUpdateAction
    {
        string CartPredicate { get; set; }

    }
}
