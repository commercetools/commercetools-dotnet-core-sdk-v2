// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class StoreRefundPolicyUrlSetMessagePayloadQueryBuilderDsl
    {
        public StoreRefundPolicyUrlSetMessagePayloadQueryBuilderDsl()
        {
        }

        public static StoreRefundPolicyUrlSetMessagePayloadQueryBuilderDsl Of()
        {
            return new StoreRefundPolicyUrlSetMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StoreRefundPolicyUrlSetMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<StoreRefundPolicyUrlSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<StoreRefundPolicyUrlSetMessagePayloadQueryBuilderDsl>(p, StoreRefundPolicyUrlSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StoreRefundPolicyUrlSetMessagePayloadQueryBuilderDsl, string> RefundPolicyUrl()
        {
            return new ComparisonPredicateBuilder<StoreRefundPolicyUrlSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("refundPolicyUrl")),
            p => new CombinationQueryPredicate<StoreRefundPolicyUrlSetMessagePayloadQueryBuilderDsl>(p, StoreRefundPolicyUrlSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
