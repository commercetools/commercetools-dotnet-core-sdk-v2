// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class StorePrivacyPolicyUrlSetMessagePayloadQueryBuilderDsl
    {
        public StorePrivacyPolicyUrlSetMessagePayloadQueryBuilderDsl()
        {
        }

        public static StorePrivacyPolicyUrlSetMessagePayloadQueryBuilderDsl Of()
        {
            return new StorePrivacyPolicyUrlSetMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StorePrivacyPolicyUrlSetMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<StorePrivacyPolicyUrlSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<StorePrivacyPolicyUrlSetMessagePayloadQueryBuilderDsl>(p, StorePrivacyPolicyUrlSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StorePrivacyPolicyUrlSetMessagePayloadQueryBuilderDsl, string> PrivacyPolicyUrl()
        {
            return new ComparisonPredicateBuilder<StorePrivacyPolicyUrlSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("privacyPolicyUrl")),
            p => new CombinationQueryPredicate<StorePrivacyPolicyUrlSetMessagePayloadQueryBuilderDsl>(p, StorePrivacyPolicyUrlSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
