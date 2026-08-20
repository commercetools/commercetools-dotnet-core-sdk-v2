// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class StoreCookiePolicyUrlSetMessagePayloadQueryBuilderDsl
    {
        public StoreCookiePolicyUrlSetMessagePayloadQueryBuilderDsl()
        {
        }

        public static StoreCookiePolicyUrlSetMessagePayloadQueryBuilderDsl Of()
        {
            return new StoreCookiePolicyUrlSetMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StoreCookiePolicyUrlSetMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<StoreCookiePolicyUrlSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<StoreCookiePolicyUrlSetMessagePayloadQueryBuilderDsl>(p, StoreCookiePolicyUrlSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StoreCookiePolicyUrlSetMessagePayloadQueryBuilderDsl, string> CookiePolicyUrl()
        {
            return new ComparisonPredicateBuilder<StoreCookiePolicyUrlSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("cookiePolicyUrl")),
            p => new CombinationQueryPredicate<StoreCookiePolicyUrlSetMessagePayloadQueryBuilderDsl>(p, StoreCookiePolicyUrlSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
