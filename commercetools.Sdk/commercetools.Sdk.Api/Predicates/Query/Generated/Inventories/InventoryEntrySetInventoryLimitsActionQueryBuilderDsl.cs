// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Inventories
{

    public partial class InventoryEntrySetInventoryLimitsActionQueryBuilderDsl
    {
        public InventoryEntrySetInventoryLimitsActionQueryBuilderDsl()
        {
        }

        public static InventoryEntrySetInventoryLimitsActionQueryBuilderDsl Of()
        {
            return new InventoryEntrySetInventoryLimitsActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<InventoryEntrySetInventoryLimitsActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<InventoryEntrySetInventoryLimitsActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<InventoryEntrySetInventoryLimitsActionQueryBuilderDsl>(p, InventoryEntrySetInventoryLimitsActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<InventoryEntrySetInventoryLimitsActionQueryBuilderDsl, long> MinCartQuantity()
        {
            return new ComparisonPredicateBuilder<InventoryEntrySetInventoryLimitsActionQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("minCartQuantity")),
            p => new CombinationQueryPredicate<InventoryEntrySetInventoryLimitsActionQueryBuilderDsl>(p, InventoryEntrySetInventoryLimitsActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<InventoryEntrySetInventoryLimitsActionQueryBuilderDsl, long> MaxCartQuantity()
        {
            return new ComparisonPredicateBuilder<InventoryEntrySetInventoryLimitsActionQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("maxCartQuantity")),
            p => new CombinationQueryPredicate<InventoryEntrySetInventoryLimitsActionQueryBuilderDsl>(p, InventoryEntrySetInventoryLimitsActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
