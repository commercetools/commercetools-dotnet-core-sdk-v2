using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Inventories
{

    public partial class InventoryEntryRemoveQuantityActionQueryBuilderDsl
    {
        public InventoryEntryRemoveQuantityActionQueryBuilderDsl()
        {
        }

        public static InventoryEntryRemoveQuantityActionQueryBuilderDsl Of()
        {
            return new InventoryEntryRemoveQuantityActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<InventoryEntryRemoveQuantityActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<InventoryEntryRemoveQuantityActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<InventoryEntryRemoveQuantityActionQueryBuilderDsl>(p, InventoryEntryRemoveQuantityActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<InventoryEntryRemoveQuantityActionQueryBuilderDsl, long> Quantity()
        {
            return new ComparisonPredicateBuilder<InventoryEntryRemoveQuantityActionQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("quantity")),
            p => new CombinationQueryPredicate<InventoryEntryRemoveQuantityActionQueryBuilderDsl>(p, InventoryEntryRemoveQuantityActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
