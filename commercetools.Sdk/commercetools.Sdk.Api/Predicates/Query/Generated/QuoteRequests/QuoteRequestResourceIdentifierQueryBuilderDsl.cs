// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.QuoteRequests
{

    public partial class QuoteRequestResourceIdentifierQueryBuilderDsl
    {
        public QuoteRequestResourceIdentifierQueryBuilderDsl()
        {
        }

        public static QuoteRequestResourceIdentifierQueryBuilderDsl Of()
        {
            return new QuoteRequestResourceIdentifierQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<QuoteRequestResourceIdentifierQueryBuilderDsl, string> TypeId()
        {
            return new ComparisonPredicateBuilder<QuoteRequestResourceIdentifierQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("typeId")),
            p => new CombinationQueryPredicate<QuoteRequestResourceIdentifierQueryBuilderDsl>(p, QuoteRequestResourceIdentifierQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<QuoteRequestResourceIdentifierQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<QuoteRequestResourceIdentifierQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<QuoteRequestResourceIdentifierQueryBuilderDsl>(p, QuoteRequestResourceIdentifierQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<QuoteRequestResourceIdentifierQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<QuoteRequestResourceIdentifierQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<QuoteRequestResourceIdentifierQueryBuilderDsl>(p, QuoteRequestResourceIdentifierQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
