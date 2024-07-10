using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.StandalonePrices
{

    public partial class StandalonePriceUpdateQueryBuilderDsl
    {
        public StandalonePriceUpdateQueryBuilderDsl()
        {
        }

        public static StandalonePriceUpdateQueryBuilderDsl Of()
        {
            return new StandalonePriceUpdateQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StandalonePriceUpdateQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<StandalonePriceUpdateQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<StandalonePriceUpdateQueryBuilderDsl>(p, StandalonePriceUpdateQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StandalonePriceUpdateQueryBuilderDsl> Actions(
            Func<commercetools.Sdk.Api.Predicates.Query.StandalonePrices.StandalonePriceUpdateActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.StandalonePrices.StandalonePriceUpdateActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StandalonePriceUpdateQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("actions"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.StandalonePrices.StandalonePriceUpdateActionQueryBuilderDsl.Of())),
                StandalonePriceUpdateQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<StandalonePriceUpdateQueryBuilderDsl> Actions()
        {
            return new CollectionPredicateBuilder<StandalonePriceUpdateQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("actions")),
                    p => new CombinationQueryPredicate<StandalonePriceUpdateQueryBuilderDsl>(p, StandalonePriceUpdateQueryBuilderDsl.Of));
        }

    }
}
