// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class QuoteRequestDeletedMessagePayloadQueryBuilderDsl
    {
        public QuoteRequestDeletedMessagePayloadQueryBuilderDsl()
        {
        }

        public static QuoteRequestDeletedMessagePayloadQueryBuilderDsl Of()
        {
            return new QuoteRequestDeletedMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<QuoteRequestDeletedMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<QuoteRequestDeletedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<QuoteRequestDeletedMessagePayloadQueryBuilderDsl>(p, QuoteRequestDeletedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
