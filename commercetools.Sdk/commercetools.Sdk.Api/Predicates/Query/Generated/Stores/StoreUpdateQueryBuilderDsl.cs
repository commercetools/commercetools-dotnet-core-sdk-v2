using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Stores
{

    public partial class StoreUpdateQueryBuilderDsl
    {
        public StoreUpdateQueryBuilderDsl()
        {
        }

        public static StoreUpdateQueryBuilderDsl Of()
        {
            return new StoreUpdateQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StoreUpdateQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<StoreUpdateQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<StoreUpdateQueryBuilderDsl>(p, StoreUpdateQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StoreUpdateQueryBuilderDsl> Actions(
            Func<commercetools.Sdk.Api.Predicates.Query.Stores.StoreUpdateActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Stores.StoreUpdateActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StoreUpdateQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("actions"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Stores.StoreUpdateActionQueryBuilderDsl.Of())),
                StoreUpdateQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<StoreUpdateQueryBuilderDsl> Actions()
        {
            return new CollectionPredicateBuilder<StoreUpdateQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("actions")),
                    p => new CombinationQueryPredicate<StoreUpdateQueryBuilderDsl>(p, StoreUpdateQueryBuilderDsl.Of));
        }

    }
}
