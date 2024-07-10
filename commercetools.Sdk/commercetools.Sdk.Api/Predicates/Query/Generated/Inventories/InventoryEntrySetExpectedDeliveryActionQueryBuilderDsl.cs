using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Inventories
{

    public partial class InventoryEntrySetExpectedDeliveryActionQueryBuilderDsl
    {
        public InventoryEntrySetExpectedDeliveryActionQueryBuilderDsl()
        {
        }

        public static InventoryEntrySetExpectedDeliveryActionQueryBuilderDsl Of()
        {
            return new InventoryEntrySetExpectedDeliveryActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<InventoryEntrySetExpectedDeliveryActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<InventoryEntrySetExpectedDeliveryActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<InventoryEntrySetExpectedDeliveryActionQueryBuilderDsl>(p, InventoryEntrySetExpectedDeliveryActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<InventoryEntrySetExpectedDeliveryActionQueryBuilderDsl, DateTime> ExpectedDelivery()
        {
            return new ComparisonPredicateBuilder<InventoryEntrySetExpectedDeliveryActionQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("expectedDelivery")),
            p => new CombinationQueryPredicate<InventoryEntrySetExpectedDeliveryActionQueryBuilderDsl>(p, InventoryEntrySetExpectedDeliveryActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
