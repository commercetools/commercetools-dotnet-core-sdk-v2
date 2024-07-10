using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.StandalonePrices
{

    public partial class StandalonePricePagedQueryResponseQueryBuilderDsl
    {
        public StandalonePricePagedQueryResponseQueryBuilderDsl()
        {
        }

        public static StandalonePricePagedQueryResponseQueryBuilderDsl Of()
        {
            return new StandalonePricePagedQueryResponseQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StandalonePricePagedQueryResponseQueryBuilderDsl, long> Limit()
        {
            return new ComparisonPredicateBuilder<StandalonePricePagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("limit")),
            p => new CombinationQueryPredicate<StandalonePricePagedQueryResponseQueryBuilderDsl>(p, StandalonePricePagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StandalonePricePagedQueryResponseQueryBuilderDsl, long> Offset()
        {
            return new ComparisonPredicateBuilder<StandalonePricePagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("offset")),
            p => new CombinationQueryPredicate<StandalonePricePagedQueryResponseQueryBuilderDsl>(p, StandalonePricePagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StandalonePricePagedQueryResponseQueryBuilderDsl, long> Count()
        {
            return new ComparisonPredicateBuilder<StandalonePricePagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("count")),
            p => new CombinationQueryPredicate<StandalonePricePagedQueryResponseQueryBuilderDsl>(p, StandalonePricePagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StandalonePricePagedQueryResponseQueryBuilderDsl, long> Total()
        {
            return new ComparisonPredicateBuilder<StandalonePricePagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("total")),
            p => new CombinationQueryPredicate<StandalonePricePagedQueryResponseQueryBuilderDsl>(p, StandalonePricePagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StandalonePricePagedQueryResponseQueryBuilderDsl> Results(
            Func<commercetools.Sdk.Api.Predicates.Query.StandalonePrices.StandalonePriceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.StandalonePrices.StandalonePriceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StandalonePricePagedQueryResponseQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("results"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.StandalonePrices.StandalonePriceQueryBuilderDsl.Of())),
                StandalonePricePagedQueryResponseQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<StandalonePricePagedQueryResponseQueryBuilderDsl> Results()
        {
            return new CollectionPredicateBuilder<StandalonePricePagedQueryResponseQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("results")),
                    p => new CombinationQueryPredicate<StandalonePricePagedQueryResponseQueryBuilderDsl>(p, StandalonePricePagedQueryResponseQueryBuilderDsl.Of));
        }

    }
}
