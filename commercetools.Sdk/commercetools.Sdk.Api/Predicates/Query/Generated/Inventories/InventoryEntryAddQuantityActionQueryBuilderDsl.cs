using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Inventories
{

    public partial class InventoryEntryAddQuantityActionQueryBuilderDsl
    {
        public InventoryEntryAddQuantityActionQueryBuilderDsl()
        {
        }

        public static InventoryEntryAddQuantityActionQueryBuilderDsl Of()
        {
            return new InventoryEntryAddQuantityActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<InventoryEntryAddQuantityActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<InventoryEntryAddQuantityActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<InventoryEntryAddQuantityActionQueryBuilderDsl>(p, InventoryEntryAddQuantityActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<InventoryEntryAddQuantityActionQueryBuilderDsl, long> Quantity()
        {
            return new ComparisonPredicateBuilder<InventoryEntryAddQuantityActionQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("quantity")),
            p => new CombinationQueryPredicate<InventoryEntryAddQuantityActionQueryBuilderDsl>(p, InventoryEntryAddQuantityActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
