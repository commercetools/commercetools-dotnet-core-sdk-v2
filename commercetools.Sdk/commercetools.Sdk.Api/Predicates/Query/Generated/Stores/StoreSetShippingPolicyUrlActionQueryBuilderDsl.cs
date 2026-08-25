// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Stores
{

    public partial class StoreSetShippingPolicyUrlActionQueryBuilderDsl
    {
        public StoreSetShippingPolicyUrlActionQueryBuilderDsl()
        {
        }

        public static StoreSetShippingPolicyUrlActionQueryBuilderDsl Of()
        {
            return new StoreSetShippingPolicyUrlActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StoreSetShippingPolicyUrlActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<StoreSetShippingPolicyUrlActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<StoreSetShippingPolicyUrlActionQueryBuilderDsl>(p, StoreSetShippingPolicyUrlActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StoreSetShippingPolicyUrlActionQueryBuilderDsl, string> ShippingPolicyUrl()
        {
            return new ComparisonPredicateBuilder<StoreSetShippingPolicyUrlActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("shippingPolicyUrl")),
            p => new CombinationQueryPredicate<StoreSetShippingPolicyUrlActionQueryBuilderDsl>(p, StoreSetShippingPolicyUrlActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
