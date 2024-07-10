using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Inventories
{

    public partial class InventoryPagedQueryResponseQueryBuilderDsl
    {
        public InventoryPagedQueryResponseQueryBuilderDsl()
        {
        }

        public static InventoryPagedQueryResponseQueryBuilderDsl Of()
        {
            return new InventoryPagedQueryResponseQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<InventoryPagedQueryResponseQueryBuilderDsl, long> Limit()
        {
            return new ComparisonPredicateBuilder<InventoryPagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("limit")),
            p => new CombinationQueryPredicate<InventoryPagedQueryResponseQueryBuilderDsl>(p, InventoryPagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<InventoryPagedQueryResponseQueryBuilderDsl, long> Offset()
        {
            return new ComparisonPredicateBuilder<InventoryPagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("offset")),
            p => new CombinationQueryPredicate<InventoryPagedQueryResponseQueryBuilderDsl>(p, InventoryPagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<InventoryPagedQueryResponseQueryBuilderDsl, long> Count()
        {
            return new ComparisonPredicateBuilder<InventoryPagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("count")),
            p => new CombinationQueryPredicate<InventoryPagedQueryResponseQueryBuilderDsl>(p, InventoryPagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<InventoryPagedQueryResponseQueryBuilderDsl, long> Total()
        {
            return new ComparisonPredicateBuilder<InventoryPagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("total")),
            p => new CombinationQueryPredicate<InventoryPagedQueryResponseQueryBuilderDsl>(p, InventoryPagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<InventoryPagedQueryResponseQueryBuilderDsl> Results(
            Func<commercetools.Sdk.Api.Predicates.Query.Inventories.InventoryEntryQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Inventories.InventoryEntryQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<InventoryPagedQueryResponseQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("results"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Inventories.InventoryEntryQueryBuilderDsl.Of())),
                InventoryPagedQueryResponseQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<InventoryPagedQueryResponseQueryBuilderDsl> Results()
        {
            return new CollectionPredicateBuilder<InventoryPagedQueryResponseQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("results")),
                    p => new CombinationQueryPredicate<InventoryPagedQueryResponseQueryBuilderDsl>(p, InventoryPagedQueryResponseQueryBuilderDsl.Of));
        }

    }
}
