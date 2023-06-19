using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Quotes
{

    public partial class QuotePagedQueryResponseQueryBuilderDsl
    {
        public QuotePagedQueryResponseQueryBuilderDsl()
        {
        }

        public static QuotePagedQueryResponseQueryBuilderDsl Of()
        {
            return new QuotePagedQueryResponseQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<QuotePagedQueryResponseQueryBuilderDsl, long> Limit()
        {
            return new ComparisonPredicateBuilder<QuotePagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("limit")),
            p => new CombinationQueryPredicate<QuotePagedQueryResponseQueryBuilderDsl>(p, QuotePagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<QuotePagedQueryResponseQueryBuilderDsl, long> Offset()
        {
            return new ComparisonPredicateBuilder<QuotePagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("offset")),
            p => new CombinationQueryPredicate<QuotePagedQueryResponseQueryBuilderDsl>(p, QuotePagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<QuotePagedQueryResponseQueryBuilderDsl, long> Count()
        {
            return new ComparisonPredicateBuilder<QuotePagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("count")),
            p => new CombinationQueryPredicate<QuotePagedQueryResponseQueryBuilderDsl>(p, QuotePagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<QuotePagedQueryResponseQueryBuilderDsl, long> Total()
        {
            return new ComparisonPredicateBuilder<QuotePagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("total")),
            p => new CombinationQueryPredicate<QuotePagedQueryResponseQueryBuilderDsl>(p, QuotePagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<QuotePagedQueryResponseQueryBuilderDsl> Results(
            Func<commercetools.Sdk.Api.Predicates.Query.Quotes.QuoteQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Quotes.QuoteQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<QuotePagedQueryResponseQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("results"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Quotes.QuoteQueryBuilderDsl.Of())),
                QuotePagedQueryResponseQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<QuotePagedQueryResponseQueryBuilderDsl> Results()
        {
            return new CollectionPredicateBuilder<QuotePagedQueryResponseQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("results")),
                    p => new CombinationQueryPredicate<QuotePagedQueryResponseQueryBuilderDsl>(p, QuotePagedQueryResponseQueryBuilderDsl.Of));
        }

    }
}
