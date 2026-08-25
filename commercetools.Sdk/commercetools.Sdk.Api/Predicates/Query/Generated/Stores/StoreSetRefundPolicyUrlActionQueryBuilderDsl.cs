// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Stores
{

    public partial class StoreSetRefundPolicyUrlActionQueryBuilderDsl
    {
        public StoreSetRefundPolicyUrlActionQueryBuilderDsl()
        {
        }

        public static StoreSetRefundPolicyUrlActionQueryBuilderDsl Of()
        {
            return new StoreSetRefundPolicyUrlActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StoreSetRefundPolicyUrlActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<StoreSetRefundPolicyUrlActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<StoreSetRefundPolicyUrlActionQueryBuilderDsl>(p, StoreSetRefundPolicyUrlActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StoreSetRefundPolicyUrlActionQueryBuilderDsl, string> RefundPolicyUrl()
        {
            return new ComparisonPredicateBuilder<StoreSetRefundPolicyUrlActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("refundPolicyUrl")),
            p => new CombinationQueryPredicate<StoreSetRefundPolicyUrlActionQueryBuilderDsl>(p, StoreSetRefundPolicyUrlActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
