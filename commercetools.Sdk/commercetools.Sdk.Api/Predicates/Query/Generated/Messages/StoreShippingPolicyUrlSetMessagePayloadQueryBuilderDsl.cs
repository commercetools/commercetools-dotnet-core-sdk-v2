// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class StoreShippingPolicyUrlSetMessagePayloadQueryBuilderDsl
    {
        public StoreShippingPolicyUrlSetMessagePayloadQueryBuilderDsl()
        {
        }

        public static StoreShippingPolicyUrlSetMessagePayloadQueryBuilderDsl Of()
        {
            return new StoreShippingPolicyUrlSetMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StoreShippingPolicyUrlSetMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<StoreShippingPolicyUrlSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<StoreShippingPolicyUrlSetMessagePayloadQueryBuilderDsl>(p, StoreShippingPolicyUrlSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StoreShippingPolicyUrlSetMessagePayloadQueryBuilderDsl, string> ShippingPolicyUrl()
        {
            return new ComparisonPredicateBuilder<StoreShippingPolicyUrlSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("shippingPolicyUrl")),
            p => new CombinationQueryPredicate<StoreShippingPolicyUrlSetMessagePayloadQueryBuilderDsl>(p, StoreShippingPolicyUrlSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
