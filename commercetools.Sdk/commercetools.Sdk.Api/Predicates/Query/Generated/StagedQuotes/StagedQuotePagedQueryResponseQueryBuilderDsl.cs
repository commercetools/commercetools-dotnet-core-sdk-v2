using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.StagedQuotes
{

    public partial class StagedQuotePagedQueryResponseQueryBuilderDsl
    {
        public StagedQuotePagedQueryResponseQueryBuilderDsl()
        {
        }

        public static StagedQuotePagedQueryResponseQueryBuilderDsl Of()
        {
            return new StagedQuotePagedQueryResponseQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StagedQuotePagedQueryResponseQueryBuilderDsl, long> Limit()
        {
            return new ComparisonPredicateBuilder<StagedQuotePagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("limit")),
            p => new CombinationQueryPredicate<StagedQuotePagedQueryResponseQueryBuilderDsl>(p, StagedQuotePagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StagedQuotePagedQueryResponseQueryBuilderDsl, long> Offset()
        {
            return new ComparisonPredicateBuilder<StagedQuotePagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("offset")),
            p => new CombinationQueryPredicate<StagedQuotePagedQueryResponseQueryBuilderDsl>(p, StagedQuotePagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StagedQuotePagedQueryResponseQueryBuilderDsl, long> Count()
        {
            return new ComparisonPredicateBuilder<StagedQuotePagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("count")),
            p => new CombinationQueryPredicate<StagedQuotePagedQueryResponseQueryBuilderDsl>(p, StagedQuotePagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StagedQuotePagedQueryResponseQueryBuilderDsl, long> Total()
        {
            return new ComparisonPredicateBuilder<StagedQuotePagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("total")),
            p => new CombinationQueryPredicate<StagedQuotePagedQueryResponseQueryBuilderDsl>(p, StagedQuotePagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StagedQuotePagedQueryResponseQueryBuilderDsl> Results(
            Func<commercetools.Sdk.Api.Predicates.Query.StagedQuotes.StagedQuoteQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.StagedQuotes.StagedQuoteQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedQuotePagedQueryResponseQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("results"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.StagedQuotes.StagedQuoteQueryBuilderDsl.Of())),
                StagedQuotePagedQueryResponseQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<StagedQuotePagedQueryResponseQueryBuilderDsl> Results()
        {
            return new CollectionPredicateBuilder<StagedQuotePagedQueryResponseQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("results")),
                    p => new CombinationQueryPredicate<StagedQuotePagedQueryResponseQueryBuilderDsl>(p, StagedQuotePagedQueryResponseQueryBuilderDsl.Of));
        }

    }
}
