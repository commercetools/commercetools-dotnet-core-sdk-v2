// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Quotes
{

    public partial class QuoteResourceIdentifierQueryBuilderDsl
    {
        public QuoteResourceIdentifierQueryBuilderDsl()
        {
        }

        public static QuoteResourceIdentifierQueryBuilderDsl Of()
        {
            return new QuoteResourceIdentifierQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<QuoteResourceIdentifierQueryBuilderDsl, string> TypeId()
        {
            return new ComparisonPredicateBuilder<QuoteResourceIdentifierQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("typeId")),
            p => new CombinationQueryPredicate<QuoteResourceIdentifierQueryBuilderDsl>(p, QuoteResourceIdentifierQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<QuoteResourceIdentifierQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<QuoteResourceIdentifierQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<QuoteResourceIdentifierQueryBuilderDsl>(p, QuoteResourceIdentifierQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<QuoteResourceIdentifierQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<QuoteResourceIdentifierQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<QuoteResourceIdentifierQueryBuilderDsl>(p, QuoteResourceIdentifierQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
