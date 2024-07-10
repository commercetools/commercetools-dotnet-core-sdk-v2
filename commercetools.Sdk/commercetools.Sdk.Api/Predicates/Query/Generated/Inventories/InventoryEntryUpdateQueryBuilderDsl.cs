using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Inventories
{

    public partial class InventoryEntryUpdateQueryBuilderDsl
    {
        public InventoryEntryUpdateQueryBuilderDsl()
        {
        }

        public static InventoryEntryUpdateQueryBuilderDsl Of()
        {
            return new InventoryEntryUpdateQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<InventoryEntryUpdateQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<InventoryEntryUpdateQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<InventoryEntryUpdateQueryBuilderDsl>(p, InventoryEntryUpdateQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<InventoryEntryUpdateQueryBuilderDsl> Actions(
            Func<commercetools.Sdk.Api.Predicates.Query.Inventories.InventoryEntryUpdateActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Inventories.InventoryEntryUpdateActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<InventoryEntryUpdateQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("actions"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Inventories.InventoryEntryUpdateActionQueryBuilderDsl.Of())),
                InventoryEntryUpdateQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<InventoryEntryUpdateQueryBuilderDsl> Actions()
        {
            return new CollectionPredicateBuilder<InventoryEntryUpdateQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("actions")),
                    p => new CombinationQueryPredicate<InventoryEntryUpdateQueryBuilderDsl>(p, InventoryEntryUpdateQueryBuilderDsl.Of));
        }

    }
}
