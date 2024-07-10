using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Inventories
{

    public partial class InventoryEntryChangeQuantityActionQueryBuilderDsl
    {
        public InventoryEntryChangeQuantityActionQueryBuilderDsl()
        {
        }

        public static InventoryEntryChangeQuantityActionQueryBuilderDsl Of()
        {
            return new InventoryEntryChangeQuantityActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<InventoryEntryChangeQuantityActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<InventoryEntryChangeQuantityActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<InventoryEntryChangeQuantityActionQueryBuilderDsl>(p, InventoryEntryChangeQuantityActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<InventoryEntryChangeQuantityActionQueryBuilderDsl, long> Quantity()
        {
            return new ComparisonPredicateBuilder<InventoryEntryChangeQuantityActionQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("quantity")),
            p => new CombinationQueryPredicate<InventoryEntryChangeQuantityActionQueryBuilderDsl>(p, InventoryEntryChangeQuantityActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
