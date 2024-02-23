using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.QuoteRequests
{

    public partial class QuoteRequestPagedQueryResponseQueryBuilderDsl
    {
        public QuoteRequestPagedQueryResponseQueryBuilderDsl()
        {
        }

        public static QuoteRequestPagedQueryResponseQueryBuilderDsl Of()
        {
            return new QuoteRequestPagedQueryResponseQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<QuoteRequestPagedQueryResponseQueryBuilderDsl, long> Limit()
        {
            return new ComparisonPredicateBuilder<QuoteRequestPagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("limit")),
            p => new CombinationQueryPredicate<QuoteRequestPagedQueryResponseQueryBuilderDsl>(p, QuoteRequestPagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<QuoteRequestPagedQueryResponseQueryBuilderDsl, long> Offset()
        {
            return new ComparisonPredicateBuilder<QuoteRequestPagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("offset")),
            p => new CombinationQueryPredicate<QuoteRequestPagedQueryResponseQueryBuilderDsl>(p, QuoteRequestPagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<QuoteRequestPagedQueryResponseQueryBuilderDsl, long> Count()
        {
            return new ComparisonPredicateBuilder<QuoteRequestPagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("count")),
            p => new CombinationQueryPredicate<QuoteRequestPagedQueryResponseQueryBuilderDsl>(p, QuoteRequestPagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<QuoteRequestPagedQueryResponseQueryBuilderDsl, long> Total()
        {
            return new ComparisonPredicateBuilder<QuoteRequestPagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("total")),
            p => new CombinationQueryPredicate<QuoteRequestPagedQueryResponseQueryBuilderDsl>(p, QuoteRequestPagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<QuoteRequestPagedQueryResponseQueryBuilderDsl> Results(
            Func<commercetools.Sdk.Api.Predicates.Query.QuoteRequests.QuoteRequestQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.QuoteRequests.QuoteRequestQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<QuoteRequestPagedQueryResponseQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("results"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.QuoteRequests.QuoteRequestQueryBuilderDsl.Of())),
                QuoteRequestPagedQueryResponseQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<QuoteRequestPagedQueryResponseQueryBuilderDsl> Results()
        {
            return new CollectionPredicateBuilder<QuoteRequestPagedQueryResponseQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("results")),
                    p => new CombinationQueryPredicate<QuoteRequestPagedQueryResponseQueryBuilderDsl>(p, QuoteRequestPagedQueryResponseQueryBuilderDsl.Of));
        }

    }
}
