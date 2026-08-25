// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class StoreTermsOfServiceUrlSetMessagePayloadQueryBuilderDsl
    {
        public StoreTermsOfServiceUrlSetMessagePayloadQueryBuilderDsl()
        {
        }

        public static StoreTermsOfServiceUrlSetMessagePayloadQueryBuilderDsl Of()
        {
            return new StoreTermsOfServiceUrlSetMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StoreTermsOfServiceUrlSetMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<StoreTermsOfServiceUrlSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<StoreTermsOfServiceUrlSetMessagePayloadQueryBuilderDsl>(p, StoreTermsOfServiceUrlSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StoreTermsOfServiceUrlSetMessagePayloadQueryBuilderDsl, string> TermsOfServiceUrl()
        {
            return new ComparisonPredicateBuilder<StoreTermsOfServiceUrlSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("termsOfServiceUrl")),
            p => new CombinationQueryPredicate<StoreTermsOfServiceUrlSetMessagePayloadQueryBuilderDsl>(p, StoreTermsOfServiceUrlSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
